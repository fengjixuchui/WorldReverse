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
	public class MonoCoopPoint3D : MonoBehaviour // TypeDefIndex: 30221
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _pointName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpOngoing; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unlockStartLine; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockStartLine; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _finishLine; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LineRenderer _unlockLineRenderer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LineRenderer _lockLineRenderer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LineRenderer _finishLineRenderer; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _endPic; // 0x68
		public bool isShow; // 0x70
	
		// Properties
		public UnityEngine.UI.Text pointName { /* [XID] */ /* 0x0000000189745BE0-0x0000000189745C00 */ get => default; } // 0x0000000183F36650-0x0000000183F366F0 
		public Button actionBtn { /* [XID] */ /* 0x000000018974D6B0-0x000000018974D6D0 */ get => default; } // 0x0000000183F36470-0x0000000183F36510 
		public Image endPic { /* [XID] */ /* 0x0000000189754CD0-0x0000000189754CF0 */ get => default; } // 0x0000000183F36510-0x0000000183F365B0 
		public GameObject grpOngoing { /* [XID] */ /* 0x000000018975BE80-0x000000018975BEA0 */ get => default; } // 0x0000000183F365B0-0x0000000183F36650 
	
		// Constructors
		public MonoCoopPoint3D() {} // 0x0000000183F363D0-0x0000000183F36470
	
		// Methods
		// [XID] // 0x0000000189763850-0x0000000189763870
		public void SetPointState(int state) {} // 0x0000000183F361A0-0x0000000183F362E0
		// [XID] // 0x000000018976B010-0x000000018976B030
		public void HidePoint(bool hide) {} // 0x0000000183F35A70-0x0000000183F35C00
		// [XID] // 0x0000000189772640-0x0000000189772660
		public void PointCheckAagin() {} // 0x0000000183F35D00-0x0000000183F35E20
		// [XID] // 0x0000000189779C90-0x0000000189779CB0
		public void SetPointStartLine(Vector3[] pos, bool isLock) {} // 0x0000000183F35F90-0x0000000183F361A0
		// [XID] // 0x00000001897818F0-0x0000000189781910
		public void SetPointFinishLine(Vector3[] pos) {} // 0x0000000183F35E20-0x0000000183F35F90
		// [XID] // 0x0000000189788E30-0x0000000189788E50
		public void HideStartLine() {} // 0x0000000183F35C00-0x0000000183F35D00
		// [XID] // 0x0000000189790420-0x0000000189790440
		public void ShowFinishLine(bool show) {} // 0x0000000183F362E0-0x0000000183F363D0
	}
}
