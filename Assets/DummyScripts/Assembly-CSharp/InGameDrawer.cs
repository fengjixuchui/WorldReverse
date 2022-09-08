/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class InGameDrawer // TypeDefIndex: 26657
{
	// Fields
	private Mesh _mesh; // 0x10
	private List<Vector3> _meshVertices; // 0x18
	private List<int> _meshIndices; // 0x20
	private List<int> _edgeIndices; // 0x28
	private CommandBuffer _faceCommand; // 0x30
	private CameraEvent _faceCameraEvent; // 0x38
	private UnityEngine.Material _faceMaterial; // 0x40
	private Shader _faceShader; // 0x48
	private CommandBuffer _edgeCommand; // 0x50
	private CameraEvent _edgeCameraEvent; // 0x58
	private UnityEngine.Material _edgeMaterial; // 0x60
	private Shader _edgeShader; // 0x68

	// Constructors
	public InGameDrawer() {} // 0x00000001817CD5E0-0x00000001817CD6C0

	// Methods
	// [XID] // 0x0000000189904820-0x0000000189904840
	public void DrawSimplePolygon(SimplePolygon polygon) {} // 0x00000001817CCB00-0x00000001817CD5E0
	// [XID] // 0x0000000189922920-0x0000000189922940
	public void ClearSimplePolygon() {} // 0x00000001817CC9C0-0x00000001817CCB00
}

