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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoRegionJoypadController : MonoBaseJoypadController // TypeDefIndex: 30873
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _name; // 0x38
		public ContextEventType gridUpEvent; // 0x40
		public ContextEventType gridDownEvent; // 0x44
		public ContextEventType gridLeftEvent; // 0x48
		public ContextEventType gridRightEvent; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private NavigationType _navigationType; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerRow[] _rowScrollers; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enableRecycle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RegionNavigationNode[] _navigationNodes; // 0x68
		private RegionInfo _lastNavRegionInfo; // 0x70
		private RegionInfo _nextNavRegionInfo; // 0x80
		private int _curRow; // 0x90
		private int _curCol; // 0x94
		private int _rowNum; // 0x98
		private int _colNum; // 0x9C
		private int _navNodeIndex; // 0xA0
		public RegionInfo _lastRegionInfo; // 0xA8
		private bool _initialized; // 0xB8
		private OnRegionChange _regionChange; // 0xC0
		private OnRegionChange _regionChangePostRefresh; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BtnChangeList[] _regionActiveBtnList; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BtnActiveFilterType _activeBtnType; // 0xE0
		private bool _suppressed; // 0xE4
		private HashSet<string> _disableRegion; // 0xE8
	
		// Properties
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x0000000189AA6730-0x0000000189AA6750 */ get => default; } // 0x0000000184432DD0-0x0000000184432E80 
	
		// Nested types
		public delegate void OnRegionChange(RegionInfo from, RegionInfo to); // TypeDefIndex: 30874; 0x0000000184422320-0x0000000184422600
	
		public enum NavigationType // TypeDefIndex: 30875
		{
			RowScroller = 0,
			NavigationNode = 1,
			Invalid = 2
		}
	
		public enum BtnActiveFilterType // TypeDefIndex: 30876
		{
			OnlyActiveBtnInList = 0,
			OnlyAcitveBtnInList_HideAllOthers = 1,
			Invalid = 2
		}
	
		[Serializable]
		public struct RegionInfo // TypeDefIndex: 30877
		{
			// Fields
			public string name; // 0x00
			public int order; // 0x08
		}
	
		[Serializable]
		public struct RegionNavigationNode // TypeDefIndex: 30878
		{
			// Fields
			public string name; // 0x00
			public int upIndex; // 0x08
			public int downIndex; // 0x0C
			public int leftIndex; // 0x10
			public int rightIndex; // 0x14
		}
	
		[Serializable]
		public struct ControllerRow // TypeDefIndex: 30879
		{
			// Fields
			public RegionInfo[] colScrollerInfos; // 0x00
		}
	
		[Serializable]
		public struct BtnChangeList // TypeDefIndex: 30880
		{
			// Fields
			public string[] btnList; // 0x00
			public string regionName; // 0x08
			public bool excludeOtherInMonoSwitch; // 0x10
		}
	
		// Constructors
		public MonoRegionJoypadController() {} // 0x0000000184432CD0-0x0000000184432DD0
	
		// Methods
		// [XID] // 0x0000000189AADDA0-0x0000000189AADDC0
		public void SetSuppressed(bool suppressed) {} // 0x0000000184432C20-0x0000000184432CD0
		// [XID] // 0x0000000189AB5750-0x0000000189AB5770
		public void SetNavRegionEnable(string name, bool enable) {} // 0x0000000184432AF0-0x0000000184432C20
		// [XID] // 0x0000000189ABD130-0x0000000189ABD150
		public void OnEnable() {} // 0x0000000184431AD0-0x0000000184431D40
		// [XID] // 0x0000000189AC4BC0-0x0000000189AC4BE0
		public void OnDisable() {} // 0x00000001844319E0-0x0000000184431AD0
		// [XID] // 0x0000000189ACC240-0x0000000189ACC260
		public override void SetBaseContext(BaseContext context) {} // 0x00000001844328D0-0x0000000184432990
		// [XID] // 0x0000000189AD3D20-0x0000000189AD3D40
		public override bool HandleJoypadControllerAction(JoypadControllerActionType action, object param) => default; // 0x00000001844314C0-0x00000001844316B0
		// [XID] // 0x0000000189ADB800-0x0000000189ADB820
		public override bool IsInvalid() => default; // 0x00000001844316B0-0x0000000184431760
		// [XID] // 0x0000000189AE3100-0x0000000189AE3120
		public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184431300-0x00000001844314C0
		// [XID] // 0x0000000189AEAA90-0x0000000189AEAAB0
		public void SetChangeRegionCB(OnRegionChange cb) {} // 0x0000000184432990-0x0000000184432A40
		// [XID] // 0x0000000189AF2380-0x0000000189AF23A0
		public void SetChangeRegionPostRefreshCB(OnRegionChange cb) {} // 0x0000000184432A40-0x0000000184432AF0
		// [XID] // 0x0000000189AF9D00-0x0000000189AF9D20
		private bool Refresh(int r, int c) => default; // 0x00000001844300E0-0x00000001844305D0
		// [XID] // 0x0000000189B01230-0x0000000189B01250
		private void ChangeRegion(RegionInfo from, RegionInfo to) {} // 0x00000001844322F0-0x0000000184432490
		// [XID] // 0x0000000189B08780-0x0000000189B087A0
		private void RefreshBtns() {} // 0x0000000184431D40-0x00000001844322F0
		// [XID] // 0x0000000189B10120-0x0000000189B10140
		private void Reset() {} // 0x0000000184432780-0x00000001844328D0
		// [XID] // 0x0000000189B17240-0x0000000189B17260
		private RegionInfo GetScrollerInfo(int r, int c) => default; // 0x0000000184431180-0x0000000184431300
		// [XID] // 0x0000000189B1EBE0-0x0000000189B1EC00
		private bool GetScrollerInfoByName(string name, ref int r, ref int c) => default; // 0x0000000184430B40-0x0000000184430D40
		// [XID] // 0x0000000189B26470-0x0000000189B26490
		private bool GetNavNodeInfoByName(string name, ref int navIndex) => default; // 0x0000000184431760-0x00000001844318E0
		// [XID] // 0x0000000189B2D740-0x0000000189B2D760
		private bool OnScrollerReady(string name, bool focus) => default; // 0x0000000184432590-0x0000000184432780
		// [XID] // 0x0000000189B34BC0-0x0000000189B34BE0
		private void ChangeLastRegion(RegionInfo region) {} // 0x0000000184431030-0x00000001844310F0
		// [XID] // 0x0000000189B3C3D0-0x0000000189B3C3F0
		public bool EnterRegion(string name) => default; // 0x0000000184430E40-0x0000000184431030
		// [XID] // 0x0000000189B44040-0x0000000189B44060
		private bool MoveUp() => default; // 0x0000000184432490-0x0000000184432590
		// [XID] // 0x0000000189B4B740-0x0000000189B4B760
		private bool MoveDown() => default; // 0x0000000184430A40-0x0000000184430B40
		// [XID] // 0x0000000189B52DB0-0x0000000189B52DD0
		private bool MoveLeft() => default; // 0x0000000184430940-0x0000000184430A40
		// [XID] // 0x0000000189B5A740-0x0000000189B5A760
		private bool MoveRight() => default; // 0x0000000184430D40-0x0000000184430E40
		// [XID] // 0x0000000189B61C50-0x0000000189B61C70
		private bool TransverseNaviNode(ContextEventType navEvent) => default; // 0x0000000184430650-0x0000000184430940
	}
}
