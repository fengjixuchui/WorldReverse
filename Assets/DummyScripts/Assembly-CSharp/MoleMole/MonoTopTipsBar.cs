/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTopTipsBar : MonoUIProxy // TypeDefIndex: 30952
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform grpTopTipBar; // 0x40
		private RectTransform canvas; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform textScroll; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text textStatic; // 0x58
		private float scrollSpeed; // 0x60
		private bool isScrolling; // 0x64
		private bool isStatic; // 0x65
		private float holdTime; // 0x68
		private const int LAST_FIVE_MINUTES = 300; // Metadata: 0x00B11AE6
	
		// Constructors
		public MonoTopTipsBar() {} // 0x0000000184881990-0x0000000184881A70
	
		// Methods
		// [XID] // 0x00000001899EA350-0x00000001899EA370
		private void Start() {} // 0x00000001848817D0-0x00000001848818D0
		// [XID] // 0x00000001899F1D20-0x00000001899F1D40
		private void Update() {} // 0x00000001848818D0-0x0000000184881990
		// [XID] // 0x00000001899F9560-0x00000001899F9580
		private void CheckAnnounce() {} // 0x0000000184881390-0x00000001848815B0
		// [XID] // 0x0000000189A00880-0x0000000189A008A0
		private void CheckCenterAnnounce(AnnounceData aData) {} // 0x0000000184880010-0x00000001848802B0
		// [XID] // 0x0000000189A08160-0x0000000189A08180
		private void CheckCountdownAnnounce(AnnounceData aData) {} // 0x0000000184880680-0x00000001848808E0
		// [XID] // 0x0000000189A0F530-0x0000000189A0F550
		private string GetDisplayText(uint timePeriod) => default; // 0x0000000184880C00-0x0000000184880DB0
		// [XID] // 0x0000000189A16C00-0x0000000189A16C20
		private void CloseTopTipsBar() {} // 0x00000001848811A0-0x00000001848812C0
		// [XID] // 0x0000000189A1E260-0x0000000189A1E280
		private void OpenTopTipsBar() {} // 0x0000000184880AE0-0x0000000184880C00
		// [XID] // 0x0000000189A25960-0x0000000189A25980
		private void ScrollTopTipsBar() {} // 0x00000001848808E0-0x0000000184880AE0
		// [XID] // 0x0000000189A2CD80-0x0000000189A2CDA0
		private void CalculateScrollSpeed() {} // 0x00000001848815B0-0x00000001848817D0
		// [XID] // 0x0000000189A34750-0x0000000189A34770
		private void StaticTextTimer() {} // 0x00000001848812C0-0x0000000184881390
		// [XID] // 0x0000000189A3BB70-0x0000000189A3BB90
		public void InitScrollText(string text) {} // 0x0000000184880DB0-0x0000000184881000
		// [XID] // 0x0000000189A43800-0x0000000189A43820
		public void InitStaticText(string text, float remainTime = 5f /* Metadata: 0x00B11AE2 */) {} // 0x0000000184881000-0x00000001848811A0
		// [XID] // 0x0000000189A4AC50-0x0000000189A4AC70
		public void CheckExpiredAnnounceDatas() {} // 0x00000001848802B0-0x0000000184880680
	}
}
