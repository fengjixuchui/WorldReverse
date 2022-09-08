/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoLevelMapUI : MonoBehaviour // TypeDefIndex: 29765
	{
		// Fields
		public RectTransform levelMapContainer; // 0x18
		public Camera mapCamera; // 0x20
		public Canvas canvas; // 0x28
		public MonoExUICamera exUICamera; // 0x30
		public MonoExUITouch exUITouch; // 0x38
		public float rectSizeXRatio; // 0x40
		public float rectSizeYRatio; // 0x44
		public int originalCanvasSize; // 0x48
		public GameObject mapGameObjectInst; // 0x50
		private uint _mapImageHandle; // 0x58
		public MonoLevelMap levelMap; // 0x60
		public Vector2 canvas2ImageScale; // 0x68
		public string currMapString; // 0x70
		public bool showDisableLimitRegion; // 0x78
		public bool hasDisablePlayed; // 0x79
	
		// Constructors
		public MonoLevelMapUI() {} // 0x000000018427C790-0x000000018427C830
	
		// Methods
		// [XID] // 0x00000001896068F0-0x0000000189606910
		public void Init() {} // 0x000000018427B9C0-0x000000018427BD10
		// [XID] // 0x000000018960E270-0x000000018960E290
		public void SetLayer(int layer) {} // 0x000000018427C370-0x000000018427C5C0
		// [XID] // 0x0000000189615900-0x0000000189615920
		public void InitTouchContenxt(BasePageContext context) {} // 0x000000018427B900-0x000000018427B9C0
		// [XID] // 0x000000018961D0E0-0x000000018961D100
		public void LoadMapImage(UnityAction callback) {} // 0x000000018427BD10-0x000000018427BEB0
		// [XID] // 0x0000000189624610-0x0000000189624630
		private void SetupRectSizeRatio() {} // 0x000000018427BEB0-0x000000018427BF50
		// [XID] // 0x000000018962BD50-0x000000018962BD70
		private void OnLoadMapImage(UnityAction callback) {} // 0x000000018427AE60-0x000000018427B190
		// [XID] // 0x0000000189633870-0x0000000189633890
		protected void OnEnable() {} // 0x000000018427C200-0x000000018427C370
		// [XID] // 0x000000018963B170-0x000000018963B190
		protected void OnDisable() {} // 0x000000018427C0B0-0x000000018427C200
		// [XID] // 0x00000001896428A0-0x00000001896428C0
		private void LoadLimitRegion() {} // 0x000000018427B800-0x000000018427B900
		// [XID] // 0x0000000189649F90-0x0000000189649FB0
		public void ShowDisableLimitRegion() {} // 0x000000018427C5C0-0x000000018427C790
		// [IDTag] // 0x0000000189651670-0x00000001896516B0
		// [XID] // 0x0000000189651670-0x00000001896516B0
		public void CenterCameraAt(Vector3 worldPosition) {} // 0x000000018427B4D0-0x000000018427B5F0
		// [IDTag] // 0x000000018965BF30-0x000000018965BF70
		// [XID] // 0x000000018965BF30-0x000000018965BF70
		public void CenterCameraAt(Vector2 levelMapPos, bool keepZ = false /* Metadata: 0x00B0FEA5 */) {} // 0x000000018427B190-0x000000018427B4D0
		// [XID] // 0x0000000189666440-0x0000000189666460
		public void ClearView(bool force) {} // 0x000000018427B5F0-0x000000018427B700
		// [XID] // 0x000000018966DC20-0x000000018966DC40
		private void OnDestroy() {} // 0x000000018427BF50-0x000000018427C0B0
	}
}
