/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoFlyAttachmentHelper : MonoBehaviour // TypeDefIndex: 31737
	{
		// Fields
		[NonSerialized]
		public string patternName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform windCtrl; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private WindZone windZone; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TailCell[] tailPoints; // 0x30
		private Color _tailColor; // 0x38
		private readonly Color _alphaColor; // 0x48
		private readonly Color _targetColor; // 0x58
		private bool _isFadeIn; // 0x68
		private bool _isFadeOut; // 0x69
		private readonly Color _deltaInColor; // 0x6C
		private readonly Color _deltaOutColor; // 0x7C
		private readonly Vector3 _startWindRotate; // 0x8C
		private readonly Vector3 _targetWindRotate; // 0x98
		private const float _windMaxPower = 1f; // Metadata: 0x00B13502
		private const float _windMinPower = 0.8f; // Metadata: 0x00B13506
		private TailTrailRenderer[] _tailTrailRenderer; // 0xA8
	
		// Nested types
		[Serializable]
		public class TailCell // TypeDefIndex: 31738
		{
			// Fields
			public Vector3 offset; // 0x10
			public Transform parent; // 0x20
	
			// Constructors
			public TailCell() {} // 0x0000000184AF6BC0-0x0000000184AF6E20
		}
	
		private struct TailTrailRenderer // TypeDefIndex: 31739
		{
			// Fields
			public uint trailHandler; // 0x00
			public GameObject trailInst; // 0x08
			public TrailRenderer[] trailRenderers; // 0x10
	
			// Constructors
			public TailTrailRenderer(uint handler, GameObject inst) {
				trailHandler = default;
				trailInst = default;
				trailRenderers = default;
			} // 0x0000000184AD9810-0x0000000184AD9840
	
			// Methods
			// [XID] // 0x000000018974EB90-0x000000018974EBB0
			public void Enable() {} // 0x0000000184AD93A0-0x0000000184AD9560
			// [XID] // 0x0000000189756260-0x0000000189756280
			public void Disable() {} // 0x0000000184AD96D0-0x0000000184AD9810
			// [XID] // 0x000000018975D5C0-0x000000018975D5E0
			public void Destroy() {} // 0x0000000184AD9560-0x0000000184AD96D0
		}
	
		// Constructors
		public MonoFlyAttachmentHelper() {} // 0x0000000184AE28B0-0x0000000184AE2AD0
	
		// Methods
		// [XID] // 0x00000001896F5060-0x00000001896F5080
		public MonoFlyAttachmentHelper AddCloneComponent(string patternName) => default; // 0x0000000184AE19D0-0x0000000184AE1AE0
		// [XID] // 0x00000001899E7290-0x00000001899E72B0
		public void UpdateWindPower(float ratio) {} // 0x0000000184AE2610-0x0000000184AE2810
		// [XID] // 0x000000018979F690-0x000000018979F6B0
		public void EnableTail() {} // 0x0000000184AE1EA0-0x0000000184AE1F50
		// [XID] // 0x000000018970B670-0x000000018970B690
		private void EnableInternal() {} // 0x0000000184AE1AE0-0x0000000184AE1BF0
		// [XID] // 0x0000000189B3AB00-0x0000000189B3AB20
		private void LoadTail() {} // 0x0000000184AE2130-0x0000000184AE2450
		// [XID] // 0x000000018971A770-0x000000018971A790
		public void DisableTail() {} // 0x0000000184AE1BF0-0x0000000184AE1CA0
		// [XID] // 0x0000000189721AF0-0x0000000189721B10
		public void ForceDisableTail() {} // 0x0000000184AE2010-0x0000000184AE2130
		// [XID] // 0x0000000189729120-0x0000000189729140
		private void DisableInternal() {} // 0x0000000184AE2450-0x0000000184AE24F0
		// [XID] // 0x00000001897309A0-0x00000001897309C0
		private void Update() {} // 0x0000000184AE2810-0x0000000184AE28B0
		// [XID] // 0x00000001897382B0-0x00000001897382D0
		private void UpdateTrailColor(ref Color color, bool disable = false /* Metadata: 0x00B13501 */) {} // 0x0000000184AE1F50-0x0000000184AE2010
		// [XID] // 0x000000018973FFC0-0x000000018973FFE0
		private void UpdateFade() {} // 0x0000000184AE1CA0-0x0000000184AE1EA0
		// [XID] // 0x0000000189747420-0x0000000189747440
		private void OnDestroy() {} // 0x0000000184AE24F0-0x0000000184AE2610
	}
}
