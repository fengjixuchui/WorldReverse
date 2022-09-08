/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	[Serializable]
	public class TouchSprite // TypeDefIndex: 7841
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite idleSprite; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite busySprite; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color idleColor; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color busyColor; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TouchSpriteShape shape; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TouchUnitType sizeUnitType; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 size; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool lockAspectRatio; // 0x50
		[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
		[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
		private Vector2 worldSize; // 0x54
		private Transform spriteParentTransform; // 0x60
		private GameObject spriteGameObject; // 0x68
		private SpriteRenderer spriteRenderer; // 0x70
		private bool state; // 0x78
	
		// Properties
		public bool Dirty { /* [XID] */ /* 0x000000018992A280-0x000000018992A2C0 */ get; /* [XID] */ /* 0x00000001899346F0-0x0000000189934730 */ set; } // 0x00000001877E3220-0x00000001877E3280 0x00000001877E3B60-0x00000001877E3BC0
		public bool Ready { /* [XID] */ /* 0x000000018993F020-0x000000018993F060 */ get; /* [XID] */ /* 0x0000000189949790-0x00000001899497D0 */ set; } // 0x00000001877E3570-0x00000001877E35D0 0x00000001877E3F50-0x00000001877E3FB0
		public bool State { /* [XID] */ /* 0x0000000189B27640-0x0000000189B27660 */ get => default; /* [XID] */ /* 0x00000001899BA540-0x00000001899BA560 */ set {} } // 0x00000001877E37C0-0x00000001877E3860 0x00000001877E4480-0x00000001877E4570
		public Sprite BusySprite { /* [XID] */ /* 0x00000001897BA620-0x00000001897BA640 */ get => default; /* [XID] */ /* 0x00000001899C9300-0x00000001899C9320 */ set {} } // 0x00000001877E3180-0x00000001877E3220 0x00000001877E3A30-0x00000001877E3B60
		public Sprite IdleSprite { /* [XID] */ /* 0x00000001899D0EB0-0x00000001899D0ED0 */ get => default; /* [XID] */ /* 0x00000001899D8350-0x00000001899D8370 */ set {} } // 0x00000001877E3350-0x00000001877E33F0 0x00000001877E3CE0-0x00000001877E3E10
		public Sprite Sprite { /* [XID] */ /* 0x00000001899DF940-0x00000001899DF960 */ set {} } // 0x00000001877E42E0-0x00000001877E4480
		public Color BusyColor { /* [XID] */ /* 0x00000001899E7470-0x00000001899E7490 */ get => default; /* [XID] */ /* 0x00000001899EE920-0x00000001899EE940 */ set {} } // 0x00000001877E30B0-0x00000001877E3180 0x00000001877E3910-0x00000001877E3A30
		public Color IdleColor { /* [XID] */ /* 0x00000001899F6170-0x00000001899F6190 */ get => default; /* [XID] */ /* 0x00000001899FD870-0x00000001899FD890 */ set {} } // 0x00000001877E3280-0x00000001877E3350 0x00000001877E3BC0-0x00000001877E3CE0
		public TouchSpriteShape Shape { /* [XID] */ /* 0x0000000189A04EC0-0x0000000189A04EE0 */ get => default; /* [XID] */ /* 0x0000000189A0C590-0x0000000189A0C5B0 */ set {} } // 0x00000001877E35D0-0x00000001877E3670 0x00000001877E3FB0-0x00000001877E40A0
		public TouchUnitType SizeUnitType { /* [XID] */ /* 0x0000000189A13F10-0x0000000189A13F30 */ get => default; /* [XID] */ /* 0x0000000189A1B180-0x0000000189A1B1A0 */ set {} } // 0x00000001877E3670-0x00000001877E3710 0x00000001877E40A0-0x00000001877E4190
		public Vector2 Size { /* [XID] */ /* 0x000000018980BC40-0x000000018980BC60 */ get => default; /* [XID] */ /* 0x0000000189A29C60-0x0000000189A29C80 */ set {} } // 0x00000001877E3710-0x00000001877E37C0 0x00000001877E4190-0x00000001877E42E0
		public Vector2 WorldSize { /* [XID] */ /* 0x0000000189A31140-0x0000000189A31160 */ get => default; } // 0x00000001877E3860-0x00000001877E3910 
		public Vector3 Position { /* [XID] */ /* 0x0000000189624020-0x0000000189624040 */ get => default; /* [XID] */ /* 0x0000000189A40400-0x0000000189A40420 */ set {} } // 0x00000001877E33F0-0x00000001877E3570 0x00000001877E3E10-0x00000001877E3F50
	
		// Constructors
		public TouchSprite() {} // 0x00000001877E2DF0-0x00000001877E2F30
		public TouchSprite(float size) {} // 0x00000001877E2F30-0x00000001877E30B0
	
		// Methods
		// [XID] // 0x0000000189953BD0-0x0000000189953BF0
		public void Create(string gameObjectName, Transform parentTransform, int sortingOrder) {} // 0x00000001877E1C10-0x00000001877E1D80
		// [XID] // 0x000000018995B3B0-0x000000018995B3D0
		public void Delete() {} // 0x00000001877E1D80-0x00000001877E1E80
		// [IDTag] // 0x0000000189962FE0-0x0000000189963020
		// [XID] // 0x0000000189962FE0-0x0000000189963020
		public void Update() {} // 0x00000001877E2940-0x00000001877E29E0
		// [IDTag] // 0x000000018996D3B0-0x000000018996D3F0
		// [XID] // 0x000000018996D3B0-0x000000018996D3F0
		public void Update(bool forceUpdate) {} // 0x00000001877E29E0-0x00000001877E2DF0
		// [XID] // 0x0000000189978160-0x0000000189978180
		private GameObject CreateSpriteGameObject(string name, Transform parentTransform) => default; // 0x00000001877E1870-0x00000001877E1A80
		// [XID] // 0x000000018997F220-0x000000018997F240
		private SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder) => default; // 0x00000001877E1A80-0x00000001877E1C10
		// [XID] // 0x0000000189B2E8C0-0x0000000189B2E8E0
		private void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size) {} // 0x00000001877E25B0-0x00000001877E2940
		// [XID] // 0x000000018998E6D0-0x000000018998E6F0
		private void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size) {} // 0x00000001877E20B0-0x00000001877E25B0
		// [IDTag] // 0x0000000189996200-0x0000000189996240
		// [XID] // 0x0000000189996200-0x0000000189996240
		public bool Contains(Vector2 testWorldPoint) => default; // 0x00000001877E1670-0x00000001877E1870
		// [IDTag] // 0x00000001899A0D50-0x00000001899A0D90
		// [XID] // 0x00000001899A0D50-0x00000001899A0D90
		public bool Contains(Touch touch) => default; // 0x00000001877E1550-0x00000001877E1670
		// [XID] // 0x0000000189655990-0x00000001896559B0
		public void DrawGizmos(Vector3 position, Color color) {} // 0x00000001877E1E80-0x00000001877E20B0
	}
}
