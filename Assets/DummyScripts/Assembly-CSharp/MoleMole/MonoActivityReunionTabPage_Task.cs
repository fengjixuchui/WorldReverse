/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

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
	public class MonoActivityReunionTabPage_Task : MonoBehaviour // TypeDefIndex: 31172
	{
		// Fields
		// [Header] // 0x0000000189718EF0-0x0000000189718F40
		[SerializeField] // 0x0000000189718EF0-0x0000000189718F40
		private Text _txtTaskRewardTitle; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Image> _imgTaskRewardStarList; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTaskRewardSubtitle; // 0x28
		// [Header] // 0x00000001897338B0-0x0000000189733900
		[SerializeField] // 0x00000001897338B0-0x0000000189733900
		[Space] // 0x00000001897338B0-0x0000000189733900
		private MihoyoButton _finalRewardActionBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _reusableList; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTaskProgress; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _taskFillSmoothMask; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTaskCurrentPoints; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTaskDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeMask; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnCTRTaskFetch; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inProgress; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _complete; // 0x78
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _btnRead; // 0x80
		// [Header] // 0x00000001897902A0-0x0000000189790300
		[SerializeField] // 0x00000001897902A0-0x0000000189790300
		[Space] // 0x00000001897902A0-0x0000000189790300
		private Text _txtTaskListTitle; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTaskRefreshDate; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gridScrollerTask; // 0x98
	
		// Properties
		public MonoUIContainer btnRead { /* [XID] */ /* 0x00000001897AE7F0-0x00000001897AE810 */ get => default; } // 0x00000001852D7DE0-0x00000001852D7E90 
		public MihoyoButton finalRewardActionBtn { /* [XID] */ /* 0x00000001897B6750-0x00000001897B6770 */ get => default; } // 0x00000001852D7FD0-0x00000001852D8070 
		public GameObject completeCheckImg { /* [XID] */ /* 0x00000001897BE590-0x00000001897BE5B0 */ get => default; } // 0x00000001852D7E90-0x00000001852D7F30 
		public GameObject inProgrss { /* [XID] */ /* 0x00000001897C5C40-0x00000001897C5C60 */ get => default; } // 0x00000001852D81C0-0x00000001852D8260 
		public GameObject completeMask { /* [XID] */ /* 0x00000001897CD460-0x00000001897CD480 */ get => default; } // 0x00000001852D7F30-0x00000001852D7FD0 
		public MonoSimpleReusableList reusableList { /* [XID] */ /* 0x00000001897D4A80-0x00000001897D4AA0 */ get => default; } // 0x00000001852D8260-0x00000001852D8300 
		public Text txtTaskRewardTitle { /* [XID] */ /* 0x00000001897DC100-0x00000001897DC120 */ get => default; } // 0x00000001852D8780-0x00000001852D8820 
		public List<Image> imgTaskRewardStarList { /* [XID] */ /* 0x00000001897E39F0-0x00000001897E3A10 */ get => default; } // 0x00000001852D8120-0x00000001852D81C0 
		public Text txtTaskRewardSubtitle { /* [XID] */ /* 0x00000001897EB6A0-0x00000001897EB6C0 */ get => default; } // 0x00000001852D86E0-0x00000001852D8780 
		public Text txtTaskProgress { /* [XID] */ /* 0x00000001897F2FA0-0x00000001897F2FC0 */ get => default; } // 0x00000001852D8590-0x00000001852D8630 
		public SmoothMask taskFillSmoothMask { /* [XID] */ /* 0x00000001897FA810-0x00000001897FA830 */ get => default; } // 0x00000001852D8300-0x00000001852D83A0 
		public Text txtTaskCurrentPoints { /* [XID] */ /* 0x0000000189801E80-0x0000000189801EA0 */ get => default; } // 0x00000001852D83A0-0x00000001852D8440 
		public Text txtTaskDesc { /* [XID] */ /* 0x00000001898092B0-0x00000001898092D0 */ get => default; } // 0x00000001852D8440-0x00000001852D84E0 
		public MonoUIContainer btnCTRTaskFetch { /* [XID] */ /* 0x0000000189810B60-0x0000000189810B80 */ get => default; } // 0x00000001852D7D40-0x00000001852D7DE0 
		public Text txtTaskListTitle { /* [XID] */ /* 0x0000000189818590-0x00000001898185B0 */ get => default; } // 0x00000001852D84E0-0x00000001852D8590 
		public Text txtTaskRefreshDate { /* [XID] */ /* 0x000000018981FD70-0x000000018981FD90 */ get => default; } // 0x00000001852D8630-0x00000001852D86E0 
		public MonoGridScroller gridScrollerTask { /* [XID] */ /* 0x0000000189827400-0x0000000189827420 */ get => default; } // 0x00000001852D8070-0x00000001852D8120 
	
		// Constructors
		public MonoActivityReunionTabPage_Task() {} // 0x00000001852D7CE0-0x00000001852D7D40
	}
}
