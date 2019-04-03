using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))] // Force this object to have a MeshRenderer
[RequireComponent(typeof(MeshFilter))] // Also a mesh filter
public class HueBar : MonoBehaviour {

	/*
		This class creates the huebar for the colour picker.
		It generates its own mesh on startup.
	*/

	Mesh mesh;
	MeshFilter filter;

	void Start() {
		filter = this.GetComponent<MeshFilter>(); // Get this objects mesh filter

		mesh = new Mesh(); // Create a mesh
		GenerateMesh(); // Generate the mesh 

		filter.mesh = mesh; // Add the mesh to the mesh filter on the object!
	}

	// Generate a square mesh for the hue bar
	void GenerateMesh() {

		// Create 14 vertices going up
		Vector3[] verts = new Vector3[14];
		for (int i = 0, y = 0; y < 7; y++) {
			verts[i++] = new Vector3(0, y, 0.001f);
			verts[i++] = new Vector3(1, y, 0.001f);
		}

		// Set vertices in mesh
		mesh.vertices = verts;

		// Manually add the triangles
		// THATS A LOT OF NUMBERS! Dont mess with this tho they have to be in that order
		mesh.SetTriangles(new List<int>() {
			0, 2, 1,
			3, 1, 2,
			2, 4, 3,
			5, 3, 4,
			4, 6, 5,
			7, 5, 6,
			6, 8, 7,
			9, 7, 8,
			8, 10, 9,
			11, 9, 10,
			10, 12, 11,
			13, 11, 12
		}, 0);

		// Set the colours for the hue
		/* From Top to bottom
			Red, Yellow, Green, Cyan, Blue, Purple, Red again
		*/
		mesh.SetColors(new List<Color>() {
			Color.red,
			Color.red,

			Color.yellow,
			Color.yellow,

			Color.green,
			Color.green,

			Color.cyan,
			Color.cyan,

			Color.blue,
			Color.blue,

			Color.magenta,
			Color.magenta,

			Color.red,
			Color.red,
		});

		// Calculate the normals for the tris because i cbf doing it myself so just let it handle itself.
		// This allowed light to affect it
		mesh.RecalculateNormals();
	}
}
