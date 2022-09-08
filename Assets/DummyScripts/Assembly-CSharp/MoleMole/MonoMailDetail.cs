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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMailDetail : MonoBehaviour // TypeDefIndex: 30822
	{
		// Fields
		private bool _haveGotAttachItem; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _sender; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _date; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCombTextContainer _content; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _attachScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _attachRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _detailTrans; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _detailSmoothMask; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _detailScroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _scrollerDeltaMultiplier; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _haveGotMark; // 0x78
		private List<SimpleItemStruct> _itemList; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _linkIterateRatioLimitY; // 0x88
		private List<GameObject> _linksInView; // 0x90
		private GameObject _selectedLinkGO; // 0x98
		private int _continueScrollCount; // 0xA0
		private bool _shouldDecreaseScrollCount; // 0xA4
		private const int FRAMECOUNT_MAX = 2; // Metadata: 0x00B115FA
	
		// Properties
		public bool isToggleCareClickEnabled { /* [XID] */ /* 0x0000000189BCFD90-0x0000000189BCFDD0 */ get; /* [XID] */ /* 0x0000000189BDA520-0x0000000189BDA560 */ private set; } // 0x000000018428D760-0x000000018428D7C0 0x000000018428B330-0x000000018428B390
		public int itemListCount { /* [XID] */ /* 0x00000001895EA2D0-0x00000001895EA2F0 */ get => default; } // 0x000000018428D7C0-0x000000018428D880 
		public Transform contentSelectedFrame { /* [XID] */ /* 0x00000001895F1730-0x00000001895F1750 */ get => default; } // 0x000000018428D670-0x000000018428D760 
		public MonoUIContainer btnFetch { /* [XID] */ /* 0x00000001895F91B0-0x00000001895F91D0 */ get => default; } // 0x000000018428D3A0-0x000000018428D490 
		public MonoUIContainer btnDelete { /* [XID] */ /* 0x00000001896007E0-0x0000000189600800 */ get => default; } // 0x000000018428D2B0-0x000000018428D3A0 
		public MonoUIContainer btnToggleCare { /* [XID] */ /* 0x0000000189608100-0x0000000189608120 */ get => default; } // 0x000000018428D580-0x000000018428D670 
		public MonoUIContainer btnPSViewLink { /* [XID] */ /* 0x000000018960FA80-0x000000018960FAA0 */ get => default; } // 0x000000018428D490-0x000000018428D580 
		public float scrollerDeltaMultiplier { /* [XID] */ /* 0x0000000189616CF0-0x0000000189616D10 */ get => default; } // 0x000000018428D930-0x000000018428D9E0 
		public List<GameObject> linksInView { /* [XID] */ /* 0x0000000189661B90-0x0000000189661BB0 */ get => default; } // 0x000000018428D880-0x000000018428D930 
	
		// Constructors
		public MonoMailDetail() {} // 0x000000018428D1A0-0x000000018428D2B0
	
		// Methods
		// [XID] // 0x000000018961E8A0-0x000000018961E8C0
		public void SynchronizedOnScroll(PointerEventData data) {} // 0x000000018428C6D0-0x000000018428C7A0
		// [XID] // 0x0000000189625CC0-0x0000000189625CE0
		public void SetMailDetailView(MailDataItem mailData, int mailState) {} // 0x000000018428BF30-0x000000018428C6D0
		// [XID] // 0x000000018962D5E0-0x000000018962D600
		public void UpdateFunctionButtonByMailData(MailDataItem mailData, int mailState) {} // 0x000000018428C7A0-0x000000018428CD30
		// [XID] // 0x00000001896351A0-0x00000001896351C0
		public Button GetItemDetailButtonByIndex(int index) => default; // 0x000000018428AA80-0x000000018428ABF0
		// [XID] // 0x000000018963C820-0x000000018963C840
		public Button GetCurrentItemDetailButton() => default; // 0x000000018428A9C0-0x000000018428AA80
		// [XID] // 0x0000000189643F40-0x0000000189643F60
		public void ResetAttachScrollerSelect(int selectIndex = -1 /* Metadata: 0x00B115F6 */) {} // 0x000000018428B8F0-0x000000018428BAA0
		// [XID] // 0x000000018964B6A0-0x000000018964B6C0
		public void IterateAttachItem(bool prev, out bool leftMost) {
			leftMost = default;
		} // 0x000000018428ABF0-0x000000018428AE70
		// [XID] // 0x0000000189652E40-0x0000000189652E60
		private void RefreshAttachItem(Transform trans, int index) {} // 0x000000018428A100-0x000000018428A710
		// [XID] // 0x000000018965A540-0x000000018965A560
		private void OnAttachItemClick(BagItem item) {} // 0x0000000184289FE0-0x000000018428A100
		// [XID] // 0x0000000189669730-0x0000000189669750
		private void InitLinkGO() {} // 0x000000018428A710-0x000000018428A9C0
		// [XID] // 0x0000000189671220-0x0000000189671240
		public void MarkSelectedGO(bool mark) {} // 0x000000018428B390-0x000000018428B500
		// [XID] // 0x0000000189678AE0-0x0000000189678B00
		public void ResetSelectedGO() {} // 0x000000018428BAA0-0x000000018428BB50
		// [XID] // 0x0000000189680120-0x0000000189680140
		public void UpdateLinkList() {} // 0x000000018428CD30-0x000000018428D0D0
		// [XID] // 0x0000000189687D10-0x0000000189687D30
		public void IterateLinkView(bool prev, out bool reachBottom) {
			reachBottom = default;
		} // 0x000000018428AE70-0x000000018428B260
		// [XID] // 0x000000018968F710-0x000000018968F730
		public void ClickSelectedLinkGO() {} // 0x0000000184289E40-0x0000000184289FE0
		// [XID] // 0x0000000189697150-0x0000000189697170
		private int LinkGOCompareTo(GameObject a, GameObject b) => default; // 0x000000018428B700-0x000000018428B8F0
		// [XID] // 0x000000018969E650-0x000000018969E670
		public void SelectLinkGO(GameObject linkGO) {} // 0x000000018428BE10-0x000000018428BF30
		// [XID] // 0x00000001896A5730-0x00000001896A5750
		private void MarkLinkGO(GameObject linkGO, bool selected_arrow) {} // 0x000000018428B500-0x000000018428B700
		// [XID] // 0x00000001896ACF50-0x00000001896ACF70
		public bool ScrolledToBottom() => default; // 0x000000018428BB50-0x000000018428BC60
		// [XID] // 0x00000001896B4570-0x00000001896B4590
		public bool ScrolledToTop() => default; // 0x000000018428BC60-0x000000018428BD30
		// [XID] // 0x00000001896BB7F0-0x00000001896BB810
		private void Update() {} // 0x000000018428D0D0-0x000000018428D1A0
		// [XID] // 0x00000001896C2C40-0x00000001896C2C60
		public void ScrollingCount() {} // 0x000000018428BD30-0x000000018428BE10
		// [XID] // 0x00000001896CA160-0x00000001896CA180
		public bool LockScrollToItem() => default; // 0x000000018428B260-0x000000018428B330
	}
}
