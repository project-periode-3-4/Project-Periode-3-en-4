using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour {

	/*
		So this is basically the main class.
		This also generates the mesh for the Colour display, check out the comments in HueBar to know what it does

		So to get an output of a colour, just put a material in the "outputMaterial" slot in Unitys Inspector


		MAKE SURE there is a Eventsystem in your game, or the UI of the slider wont work.
		There should only be 1 Eventsystem in your game so check first in your Hierarchy
		To make an Eventsystem, just right click on your Hierarchy go to UI and select "Event System"

		The ColourPicker cant be rotated, it has to be facing forwards!
		If you want to have it rotated a few values have to change in code for it to work again.

		If you're getting any errors make sure everything in the "Mesh Generator" script on the "ColourPicker" prefab are filled
		with the right stuff.
		Slider: Should be the object called "Slider" child to the "HueBar", which is child to the "ColourPicker".
				if you cant find it place it in the scene and once you done it all just click "Apply" in the Inspector.
		Picker: This should be the child object called "Picker" pretty easy.
		Output Material: This has to be an empty material, just create a material you wish to output the colour to and 
						 drag and drop it into this variable.

		You can have multiple colour pickers by duplicating it and adding in different Output materials.

		Easy as that, if you got anything else you need to know just ask.

	*/

	private Mesh mesh;
	private MeshFilter filter;

	private Color colour = Color.red; // Starting colour for the Colour Display

	public Slider slider; // The Slider class for the HueBar
	public GameObject picker; // The Object that is used to display the cursor on the Colour Display. (The Sphere thing)

	private bool isHoldingDown = false; // Is the user holding the mouse down
	private Vector2 pointerPos = new Vector2(0,0); // Current position of the 'Picker' on the Colour Display
	public Material outputMaterial; // The material to output the selected colour to. USE THIS TO GET THE COLOUR!

	void Start () {
		// Just a quick null check
		if(slider != null) slider.value = 0; 
		else Debug.LogWarning("Add Slider to script!");
		
		filter = this.GetComponent<MeshFilter>();

		mesh = new Mesh();
		GenerateMesh(); // Check HueBar.cs to know what this does

		filter.mesh = mesh;
		this.GetComponent<MeshCollider>().sharedMesh = mesh; // Add the generated mesh to the mesh collider too
	}
	
	// Update is called once per frame
	void Update () {
		// Convert the current colour to HSV, this allows us to edit it easier than using RGB
		float h, v, s;
		Color.RGBToHSV(colour, out h, out s, out v);

		h = slider.value; // Set the H value to the current HueBar Value

		colour = Color.HSVToRGB(h, s, v); // Revert the colour back to RGB

		// Everything Colour Picker Related!
		ColourPicker();

		// Generate the new mesh
		GenerateMesh();
		filter.mesh = mesh; // Add it back to the mesh filter

		// Convert the current position of the Colour Picker to colours
		v = (pointerPos.y == 0) ? 0 : pointerPos.y / 6.0f; // Also makes sure we're not dividing by 0, because that will cause errors
		s = (pointerPos.x == 0) ? 1.0f : 1.0f - (pointerPos.x / 6.0f); // Does the same but because the main colour is on the opposite side of the Colour Display we have to reverse it

		// Convert the values HSB back to RGB, to add into our output colour
		Color output = Color.HSVToRGB(h, s, v);
		outputMaterial.color = output; // Set the Output material colour to the selected colour
	}

	void ColourPicker() {
		// If the left mouse button is pressed
		if(Input.GetMouseButtonDown(0))
			MovePicker(); // Move the picker cursor to the position the player has clicked

		// If the left mouse button is held
		if(Input.GetMouseButton(0)) {
			// Check in "MovePicker()" to know what all this does
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red, 2.0f);
			if(Physics.Raycast(ray, out hit, 1000.0f)) {
				if(hit.collider.gameObject == picker) { // If ray has hit our picker cursor (If player is holding mouse down on the picker)
					isHoldingDown = true; 
				}
			}

			if(isHoldingDown == true) {
				// Convert the pickers world position to screen space
				Vector3 pos = Camera.main.WorldToScreenPoint(picker.transform.localPosition);
				pos.x = Input.mousePosition.x; // Set the screenspace position to the mouse position
				pos.y = Input.mousePosition.y;
				pos.z = this.transform.position.z + -Camera.main.transform.position.z; // Offset the Z with the Cameras Position

				// Convert the new position back to world space
				Vector3 newPos = Camera.main.ScreenToWorldPoint(pos);
				newPos -= this.transform.position;
				newPos.z = 0;

				// Just a real simple AABB (Basically a box collision check to keep the Picker Cursor inside the colour display box)
				if(newPos.x > 6) newPos.x = 6;
				if(newPos.x < 0) newPos.x = 0;
				if(newPos.y > 6) newPos.y = 6;
				if(newPos.y < 0) newPos.y = 0;

				picker.transform.localPosition = newPos;// - new Vector3(this.transform.position.x, this.transform.position.y, 0);
				pointerPos = newPos;// - this.transform.position;
			}
		}

		// If mouse input is up
		if(Input.GetMouseButtonUp(0)) {
			isHoldingDown = false;
		}
	}


	void MovePicker() {
		// Shoot a ray from the mouse position
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit; // the hit info from the ray

		// If you dont know what a raycast is, its basically a line that gets shot out from an origin point following one direction.
		// And if it hits anything we can get all the infomation from "RaycastHit"

		if(Physics.Raycast(ray, out hit, 1000.0f)) { // This shoots the ray out, true if it hit something
			if(hit.collider.gameObject == this.gameObject) { // If we hit our colour display
				picker.transform.position = new Vector3(hit.point.x, hit.point.y, this.transform.position.z); // Move the colour picker to the position we hit
			}
		}
	}

	void GenerateMesh() {
		mesh.SetVertices(new List<Vector3>() {
			new Vector3(0, 0, 0),
			new Vector3(0, 6, 0),
			new Vector3(6, 6, 0),
			new Vector3(6, 0, 0)
		});

		mesh.SetTriangles(new List<int>() {
			0, 1, 3,
			2, 3, 1
		}, 0);

		mesh.SetColors(new List<Color>() {
			Color.black,
			colour,
			Color.white,
			Color.black
		});

		mesh.RecalculateNormals();
	}
}
