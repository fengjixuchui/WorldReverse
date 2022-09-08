/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace UnityEngine.UI
{
	public sealed class SimpleText : MaskableGraphic // TypeDefIndex: 26535
	{
		// Fields
		public static readonly int MAX_CHARACTER_NUM; // 0x00
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Shader shader; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Font m_Font; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_FontSize; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private FontStyle m_FontStyle; // 0xE4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TextAnchor m_Alignment; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_OutlineEnabled; // 0xEC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color m_OutlineColor; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 m_OutlineDistance; // 0x100
		private bool m_IsTextMaterialParamsUpdating; // 0x108
		[SerializeField] // 0x00000001896BF960-0x00000001896BF9A0
		// [TextArea] // 0x00000001896BF960-0x00000001896BF9A0
		private string m_Text; // 0x110
		private Color m_CachedColor; // 0x118
		private UnityEngine.Material m_SimpleTextMaterial; // 0x128
		private UnityEngine.Material m_ModifiedMaterial; // 0x130
		private Vector3 m_CachedLossyScale; // 0x138
		private readonly Vector4[] m_CharUVandPosOffsets; // 0x148
		private readonly Vector3[] _Corners; // 0x150
		private readonly UIVertex[] m_TempVerts; // 0x158
		private readonly Vector2[] m_TempOutlineOffset; // 0x160
	
		// Properties
		public Font font { get => default; set {} } // 0x00000001852381F0-0x0000000185238250 0x0000000185238D30-0x0000000185238DF0
		public int fontSize { get => default; set {} } // 0x0000000185238130-0x0000000185238190 0x0000000185238C30-0x0000000185238CB0
		public FontStyle fontStyle { get => default; set {} } // 0x0000000185238190-0x00000001852381F0 0x0000000185238CB0-0x0000000185238D30
		public TextAnchor alignment { get => default; set {} } // 0x0000000185238060-0x00000001852380C0 0x0000000185238970-0x00000001852389F0
		public bool outlineEnabled { get => default; set {} } // 0x0000000185238690-0x00000001852386F0 0x0000000185238EF0-0x0000000185238F70
		public Color outlineColor { get => default; set {} } // 0x00000001852385B0-0x0000000185238620 0x0000000185238DF0-0x0000000185238E70
		public Vector2 outlineDistance { get => default; set {} } // 0x0000000185238620-0x0000000185238690 0x0000000185238E70-0x0000000185238EF0
		public override Texture mainTexture { get => default; } // 0x0000000185238250-0x00000001852384F0 
		public string text { get => default; set {} } // 0x0000000185238910-0x0000000185238970 0x0000000185238F70-0x00000001852390B0
		public override Color color { get => default; set {} } // 0x00000001852380C0-0x0000000185238130 0x00000001852389F0-0x0000000185238C30
		public override Color meshColor { get => default; } // 0x00000001852384F0-0x00000001852385B0 
		public float pixelsPerUnit { get => default; } // 0x00000001852386F0-0x0000000185238910 
	
		// Constructors
		public SimpleText() {} // 0x0000000185237D00-0x0000000185238060
		static SimpleText() {} // 0x0000000185237CA0-0x0000000185237D00
	
		// Methods
		private void ValidateText() {} // 0x0000000185237B20-0x0000000185237CA0
		private static bool IsRGBEqual(Color color1, Color color2) => default; // 0x0000000185235640-0x00000001852356D0
		public static bool SetColor(ref Color currentValue, Color newValue) => default; // 0x00000001852362E0-0x0000000185236380
		protected override void SyncCanvasRendererColor() {} // 0x0000000185236380-0x0000000185236490
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001852356D0-0x0000000185235830
		private static void TransformPoints(Vector3[] points, Matrix4x4 mat) {} // 0x0000000185236490-0x00000001852365A0
		private void Update() {} // 0x0000000185237970-0x0000000185237B20
		public void OnFontTextureRebuilt(Font font) {} // 0x0000000185235A20-0x0000000185235A90
		public void UpdateTextMaterialParams() {} // 0x00000001852365A0-0x0000000185237970
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x0000000185235A90-0x00000001852362E0
		public override UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMat) => default; // 0x0000000185235410-0x0000000185235640
		protected override void OnEnable() {} // 0x0000000185235960-0x0000000185235A20
		protected override void OnDisable() {} // 0x0000000185235830-0x0000000185235960
		private static void DestroyEX(UnityEngine.Object obj) {} // 0x0000000185235320-0x0000000185235410
	}
}
