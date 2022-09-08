/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[AttributeUsage(AttributeTargets.All)] // 0x00000001896D1B50-0x00000001896D1B70
public class SECTR_ToolTip : Attribute // TypeDefIndex: 31945
{
	// Fields
	private string tipText; // 0x10
	private string dependentProperty; // 0x18
	private float min; // 0x20
	private float max; // 0x24
	private System.Type enumType; // 0x28
	private bool hasRange; // 0x30
	private bool devOnly; // 0x31
	private bool sceneObjectOverride; // 0x32
	private bool allowSceneObjects; // 0x33
	private bool treatAsLayer; // 0x34

	// Properties
	public string TipText { get => default; } // 0x0000000181B5B6F0-0x0000000181B5B750 
	public string DependentProperty { get => default; } // 0x0000000181B5B430-0x0000000181B5B490 
	public float Min { get => default; } // 0x0000000181B5B620-0x0000000181B5B690 
	public float Max { get => default; } // 0x0000000181B5B5B0-0x0000000181B5B620 
	public System.Type EnumType { get => default; } // 0x0000000181B5B4F0-0x0000000181B5B550 
	public bool HasRange { get => default; } // 0x0000000181B5B550-0x0000000181B5B5B0 
	public bool DevOnly { get => default; } // 0x0000000181B5B490-0x0000000181B5B4F0 
	public bool SceneObjectOverride { get => default; } // 0x0000000181B5B690-0x0000000181B5B6F0 
	public bool AllowSceneObjects { get => default; } // 0x0000000181B5B3D0-0x0000000181B5B430 
	public bool TreatAsLayer { get => default; } // 0x0000000181B5B750-0x0000000181B5B7B0 

	// Constructors
	public SECTR_ToolTip() {} // Dummy constructor
	public SECTR_ToolTip(string tipText) {} // 0x0000000181B5AF50-0x0000000181B5AFE0
	public SECTR_ToolTip(string tipText, float min, float max) {} // 0x0000000181B5B080-0x0000000181B5B130
	public SECTR_ToolTip(string tipText, string dependentProperty) {} // 0x0000000181B5AEB0-0x0000000181B5AF50
	public SECTR_ToolTip(string tipText, string dependentProperty, float min, float max) {} // 0x0000000181B5B270-0x0000000181B5B330
	public SECTR_ToolTip(string tipText, bool devOnly) {} // 0x0000000181B5B330-0x0000000181B5B3D0
	public SECTR_ToolTip(string tipText, bool devOnly, bool treatAsLayer) {} // 0x0000000181B5B130-0x0000000181B5B1D0
	public SECTR_ToolTip(string tipText, string dependentProperty, System.Type enumType) {} // 0x0000000181B5AFE0-0x0000000181B5B080
	public SECTR_ToolTip(string tipText, string dependentProperty, bool allowSceneObjects) {} // 0x0000000181B5B1D0-0x0000000181B5B270
}

