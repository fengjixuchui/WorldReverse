/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMainPageChatDisplayer : MonoBehaviour, INotifyInterface // TypeDefIndex: 28487
	{
		// Fields
		public const int MAX_COUNT = 5; // Metadata: 0x00B0D8A9
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _isFold; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _foldTimer; // 0x1C
		private uint _myUid; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MainPageChatDisplayerType _displayType; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _showText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _pluginKeyPC; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _containerKeyPS4; // 0x38
		private StringBuilder _sb; // 0x40
		private Animator _animator; // 0x48
	
		// Properties
		public MonoMaskController maskController { /* [XID] */ /* 0x000000018965D860-0x000000018965D880 */ get => default; } // 0x0000000184290560-0x0000000184290660 
	
		// Constructors
		public MonoMainPageChatDisplayer() {} // 0x00000001842904B0-0x0000000184290560
	
		// Methods
		// [XID] // 0x00000001896218B0-0x00000001896218D0
		private void Awake() {} // 0x000000018428F5A0-0x000000018428F680
		// [XID] // 0x0000000189629140-0x0000000189629160
		private void OnDestroy() {} // 0x000000018428FDE0-0x000000018428FEC0
		// [XID] // 0x0000000189630AE0-0x0000000189630B00
		private void Start() {} // 0x0000000184290280-0x00000001842903D0
		// [XID] // 0x00000001896385C0-0x00000001896385E0
		private void OnEnable() {} // 0x000000018428FEC0-0x000000018428FF70
		// [XID] // 0x000000018963F9A0-0x000000018963F9C0
		private void Update() {} // 0x00000001842903D0-0x00000001842904B0
		// [XID] // 0x00000001896471C0-0x00000001896471E0
		public void Fold(bool fold) {} // 0x000000018428F750-0x000000018428F810
		// [XID] // 0x000000018964E870-0x000000018964E890
		private void RefreshFold() {} // 0x000000018428F810-0x000000018428F8E0
		// [XID] // 0x00000001896560A0-0x00000001896560C0
		public void RefreshIcons() {} // 0x000000018428FF70-0x0000000184290280
		// [XID] // 0x0000000189664F40-0x0000000189664F60
		public void ClearText() {} // 0x000000018428F680-0x000000018428F750
		// [XID] // 0x000000018966C580-0x000000018966C5A0
		private void RefreshText() {} // 0x000000018428F8E0-0x000000018428FD00
		// [XID] // 0x0000000189674440-0x0000000189674460
		bool MoleMole.INotifyInterface.OnNotify(Notify ntf) => default; // 0x000000018428FD00-0x000000018428FDE0
	}
}
