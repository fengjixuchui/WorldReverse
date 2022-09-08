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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTreasureHuntMap : MonoSpriteProxy // TypeDefIndex: 30959
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _mapArea; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _imgAreaCircle; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _cellSize; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _mapTrans; // 0x38
		private Dictionary<int, TreasureHuntMapItem> id2PathDict; // 0x40
		private List<int> _toBeRemovedMapItemIdList; // 0x48
	
		// Properties
		public Transform MapArea { /* [XID] */ /* 0x0000000189706F50-0x0000000189706F70 */ get => default; } // 0x000000018488B960-0x000000018488BA00 
	
		// Constructors
		public MonoTreasureHuntMap() {} // 0x000000018488B8A0-0x000000018488B960
	
		// Methods
		// [XID] // 0x000000018970E810-0x000000018970E830
		public void SetImgAreaScale(float radius) {} // 0x000000018488AFF0-0x000000018488B3A0
		// [XID] // 0x0000000189715C40-0x0000000189715C60
		public void ShowTreasureMap(Vector2 pos) {} // 0x000000018488B3A0-0x000000018488B8A0
		// [XID] // 0x000000018971D680-0x000000018971D6A0
		public void ReleaseCells(List<int> idLst) {} // 0x000000018488AD50-0x000000018488AF20
		// [XID] // 0x0000000189724A50-0x0000000189724A70
		public void SetCurImageSprite(Image curImage, string terrainName) {} // 0x000000018488AF20-0x000000018488AFF0
		// [XID] // 0x000000018972C2A0-0x000000018972C2C0
		public void CenterOffset(Vector2 pos) {} // 0x000000018488A690-0x000000018488AAE0
		// [XID] // 0x0000000189733960-0x0000000189733980
		protected override void OnDestroy() {} // 0x000000018488AB40-0x000000018488AD50
	}
}
