/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	internal class MonoQuestTrace : MonoBehaviour // TypeDefIndex: 31261
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _questMainIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _arrow; // 0x38
		public SimpleText _distanceS; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _disGrp; // 0x48
		private MapTagDataConfig _showBigWorldInfoConfig; // 0x50
		private uint _mainQuestId; // 0x58
		private const float ARROW_SHOW_MAX_DIST = 80f; // Metadata: 0x00B1212A
		private List<Tuple<Vector3, float>> _targetPosDataList; // 0x60
		private bool arrowUp; // 0x68
		private float TICK_DELT; // 0x6C
		private float lastTime; // 0x70
		private bool _showArrow; // 0x74
		private Vector3 upVec; // 0x78
		private Vector3 downVec; // 0x84
	
		// Properties
		public uint mainQuestId { /* [XID] */ /* 0x00000001896A9FF0-0x00000001896AA010 */ get => default; } // 0x0000000184427CA0-0x0000000184427D40 
		public Button button { /* [XID] */ /* 0x00000001896B0D90-0x00000001896B0DB0 */ get => default; } // 0x0000000184427C00-0x0000000184427CA0 
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x00000001896B8A10-0x00000001896B8A30 */ get => default; } // 0x0000000184427DE0-0x0000000184427E80 
		public Image questMainIcon { /* [XID] */ /* 0x00000001896BFC50-0x00000001896BFC70 */ get => default; } // 0x0000000184427D40-0x0000000184427DE0 
	
		// Constructors
		public MonoQuestTrace() {} // 0x0000000184427AB0-0x0000000184427C00
	
		// Methods
		// [XID] // 0x00000001896C7510-0x00000001896C7530
		public void Tick() {} // 0x00000001844272F0-0x0000000184427AB0
		// [XID] // 0x00000001896CEC70-0x00000001896CEC90
		public void SetTargetPos(Vector3 pos, float radius = -1f /* Metadata: 0x00B12122 */) {} // 0x0000000184427060-0x00000001844271C0
		// [XID] // 0x00000001896D6070-0x00000001896D6090
		public void ClearTargetPos() {} // 0x0000000184426DF0-0x0000000184426EA0
		// [XID] // 0x00000001896DD620-0x00000001896DD640
		public void SetBigWorldInfoConfig(MapTagDataConfig config) {} // 0x0000000184426FB0-0x0000000184427060
		// [XID] // 0x00000001896E4D20-0x00000001896E4D40
		public void AddTargetPos(Vector3 pos, float radius = -1f /* Metadata: 0x00B12126 */) {} // 0x0000000184426CB0-0x0000000184426DF0
		// [XID] // 0x00000001896EC220-0x00000001896EC240
		public void SetArrow(bool up) {} // 0x0000000184426EA0-0x0000000184426FB0
		// [XID] // 0x00000001896F39D0-0x00000001896F39F0
		public void ShowDisGrp(bool show) {} // 0x00000001844271C0-0x00000001844272F0
	}
}
