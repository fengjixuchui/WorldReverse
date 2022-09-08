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
	public class MonoActivityAsterPage_Little : MonoBehaviour // TypeDefIndex: 31147
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNotOpen; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpComplete; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpMission; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tabTitleDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tabDesc; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _taskScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _intro; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _stroy; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _stroyTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTitle; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockDesc; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTime; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockTimeGrp; // 0x80
	
		// Properties
		public bool ShowNotOpenGrp { /* [XID] */ /* 0x000000018963C720-0x000000018963C740 */ set {} } // 0x0000000184C74A70-0x0000000184C74B60
		public bool ShowCompleteGrp { /* [XID] */ /* 0x0000000189643E50-0x0000000189643E70 */ set {} } // 0x0000000184C747A0-0x0000000184C74890
		public bool ShowMissionGrp { /* [XID] */ /* 0x000000018964B590-0x000000018964B5B0 */ set {} } // 0x0000000184C74980-0x0000000184C74A70
		public bool ShowLockTimeGrp { /* [XID] */ /* 0x0000000189652DA0-0x0000000189652DC0 */ set {} } // 0x0000000184C74890-0x0000000184C74980
		public string tabTitleDesc { /* [XID] */ /* 0x000000018965A4A0-0x000000018965A4C0 */ set {} } // 0x0000000184C75180-0x0000000184C75260
		public string tabDesc { /* [XID] */ /* 0x0000000189661AF0-0x0000000189661B10 */ set {} } // 0x0000000184C750A0-0x0000000184C75180
		public MonoGridScroller taskScroller { /* [XID] */ /* 0x0000000189669690-0x00000001896696B0 */ get => default; } // 0x0000000184C74700-0x0000000184C747A0 
		public string intro { /* [XID] */ /* 0x0000000189671180-0x00000001896711A0 */ set {} } // 0x0000000184C74B60-0x0000000184C74C40
		public string stroy { /* [XID] */ /* 0x0000000189678A40-0x0000000189678A60 */ set {} } // 0x0000000184C74FC0-0x0000000184C750A0
		public string stroyTitle { /* [XID] */ /* 0x0000000189680040-0x0000000189680060 */ set {} } // 0x0000000184C74EE0-0x0000000184C74FC0
		public string lockTitle { /* [XID] */ /* 0x0000000189687C70-0x0000000189687C90 */ set {} } // 0x0000000184C74E00-0x0000000184C74EE0
		public string lockDesc { /* [XID] */ /* 0x000000018968F670-0x000000018968F690 */ set {} } // 0x0000000184C74C40-0x0000000184C74D20
		public string lockTime { /* [XID] */ /* 0x00000001896970D0-0x00000001896970F0 */ set {} } // 0x0000000184C74D20-0x0000000184C74E00
		public MonoUIContainer BtnGotoTask_1 { /* [XID] */ /* 0x000000018969E5B0-0x000000018969E5D0 */ get => default; } // 0x0000000184C74580-0x0000000184C74640 
		public MonoUIContainer BtnReceive_1 { /* [XID] */ /* 0x00000001896A5690-0x00000001896A56B0 */ get => default; } // 0x0000000184C74640-0x0000000184C74700 
		public MonoUIContainer BtnGotoLocation_1 { /* [XID] */ /* 0x00000001896ACED0-0x00000001896ACEF0 */ get => default; } // 0x0000000184C744C0-0x0000000184C74580 
		public MonoUIContainer BtnCourse_1 { /* [XID] */ /* 0x00000001896B44B0-0x00000001896B44D0 */ get => default; } // 0x0000000184C74400-0x0000000184C744C0 
		public MonoUIContainer BtnAttribute_1 { /* [XID] */ /* 0x00000001896BB790-0x00000001896BB7B0 */ get => default; } // 0x0000000184C74340-0x0000000184C74400 
	
		// Constructors
		public MonoActivityAsterPage_Little() {} // 0x0000000184C742A0-0x0000000184C74340
	
		// Methods
		// [XID] // 0x00000001896C2C00-0x00000001896C2C20
		public void SetGrpState(AsterLittleStageState state) {} // 0x0000000184C741C0-0x0000000184C742A0
	}
}
