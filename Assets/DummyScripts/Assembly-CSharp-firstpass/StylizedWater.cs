/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[ExecuteInEditMode] // 0x00000001896F9160-0x00000001896F91D0
// [RequireComponent] // 0x00000001896F9160-0x00000001896F91D0
public class StylizedWater : MonoBehaviour // TypeDefIndex: 10681
{
	// Fields
	// [Header] // 0x0000000189708280-0x00000001897082B0
	public Color waterColor; // 0x18
	public Color fresnelColor; // 0x28
	public Color rimColor; // 0x38
	// [Header] // 0x0000000189711550-0x0000000189711580
	public float transparency; // 0x48
	public Texture reflectionCubemap; // 0x50
	public float glossiness; // 0x58
	public float fresnel; // 0x5C
	public float surfaceHighlight; // 0x60
	public float surfaceHighlightTiling; // 0x64
	public float surfaceHighlightSize; // 0x68
	public float depth; // 0x6C
	public float depthDarkness; // 0x70
	public float rimSize; // 0x74
	public float rimFalloff; // 0x78
	public bool worldSpaceTiling; // 0x7C
	public float tiling; // 0x80
	public float rimTiling; // 0x84
	public float refractionAmount; // 0x88
	public float waveStrength; // 0x8C
	public Texture customIntersection; // 0x90
	public Texture customNormal; // 0x98
	public Texture normals; // 0xA0
	public Texture shadermap; // 0xA8
	public float tesselation; // 0xB0
	// [Header] // 0x000000018971A3B0-0x000000018971A3E0
	public ProceduralMaterial substance; // 0xB8
	public float seed; // 0xC0
	public float normalStrength; // 0xC4
	public string[] intersectionStyleList; // 0xC8
	public int intersectionStyle; // 0xD0
	public string[] waveStyleList; // 0xD8
	public int waveStyle; // 0xE0
	public float waveSpeed; // 0xE4
	public bool useCustomIntersection; // 0xE8
	public bool useCustomNormals; // 0xE9
	public UnityEngine.Material material; // 0xF0
	public bool isMobileAdvanced; // 0xF8
	public bool isMobileBasic; // 0xF9
	public string shaderName; // 0x100
	// [Header] // 0x0000000189722ED0-0x0000000189722F00
	public bool showColors; // 0x108
	public bool showSurface; // 0x109
	public bool showIntersection; // 0x10A
	public bool showHighlights; // 0x10B
	public bool showDepth; // 0x10C
	public bool showWaves; // 0x10D
	public bool hasSubstanceParams; // 0x10E

	// Constructors
	public StylizedWater() {} // 0x0000000186F3B140-0x0000000186F3B5B0

	// Methods
	public void getProperties() {} // 0x0000000186F3B5B0-0x0000000186F3B6C0
	private void getSubstanceProperties() {} // 0x0000000186F3BBD0-0x0000000186F3BE00
	private void getShaderProperties() {} // 0x0000000186F3B6C0-0x0000000186F3BBD0
}

