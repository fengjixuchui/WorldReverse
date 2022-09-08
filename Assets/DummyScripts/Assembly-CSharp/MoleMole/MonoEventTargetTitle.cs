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
	public class MonoEventTargetTitle : MonoBehaviour // TypeDefIndex: 31289
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _halo; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _dailyTaskHalo; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _randTaskHalo; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _completeHalo; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _failHalo; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _startTitle; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _startSubTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _startHighlight; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _dailyTaskHighlight; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _randTaskHighlight; // 0x98
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _failTitle; // 0xA8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _completeTitle; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _completeHighlight; // 0xB8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _descriptionTitle; // 0xC0
		private static readonly int RANDOM_TASK; // 0x00
		private static readonly int END; // 0x04
	
		// Properties
		public Sprite icon { /* [XID] */ /* 0x0000000189825750-0x0000000189825770 */ set {} } // 0x000000018561ED10-0x000000018561EDD0
		public string startTitle { /* [XID] */ /* 0x000000018983BDB0-0x000000018983BDD0 */ set {} } // 0x000000018561EEA0-0x000000018561EF70
		public string startSubTitle { /* [XID] */ /* 0x0000000189843400-0x0000000189843420 */ set {} } // 0x000000018561EDD0-0x000000018561EEA0
		public string completeTitle { /* [XID] */ /* 0x000000018984A920-0x000000018984A940 */ set {} } // 0x000000018561EAA0-0x000000018561EB70
		public string failTitle { /* [XID] */ /* 0x0000000189851D20-0x0000000189851D40 */ set {} } // 0x000000018561EC40-0x000000018561ED10
		public string description { /* [XID] */ /* 0x00000001898595A0-0x00000001898595C0 */ set {} } // 0x000000018561EB70-0x000000018561EC40
	
		// Constructors
		public MonoEventTargetTitle() {} // 0x000000018561EA00-0x000000018561EAA0
		static MonoEventTargetTitle() {} // 0x000000018561E960-0x000000018561EA00
	
		// Methods
		// [XID] // 0x000000018982CF60-0x000000018982CF80
		public void ToDailyTaskColor() {} // 0x000000018561E700-0x000000018561E830
		// [XID] // 0x0000000189834760-0x0000000189834780
		public void ToRandTaskColor() {} // 0x000000018561E830-0x000000018561E960
		// [XID] // 0x00000001898606C0-0x00000001898606E0
		public void OnStart(bool randomTask = false /* Metadata: 0x00B1213B */) {} // 0x000000018561E540-0x000000018561E700
		// [XID] // 0x0000000189867D90-0x0000000189867DB0
		public void OnComplete(bool randomTask = false /* Metadata: 0x00B1213C */) {} // 0x000000018561E0A0-0x000000018561E260
		// [XID] // 0x000000018986F330-0x000000018986F350
		public void OnFail() {} // 0x000000018561E3D0-0x000000018561E540
		// [XID] // 0x0000000189876960-0x0000000189876980
		public void OnDescription() {} // 0x000000018561E260-0x000000018561E3D0
		// [XID] // 0x000000018987E480-0x000000018987E4A0
		public bool IsEnd() => default; // 0x000000018561DF60-0x000000018561E0A0
	}
}
