/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMapCursor : MonoBehaviour // TypeDefIndex: 31132
	{
		// Fields
		private bool _show; // 0x18
		private MonoMapMark _target; // 0x20
		private Animator _animator; // 0x28
		private Vector3 _normalScale; // 0x30
		private Vector3 _largeScale; // 0x3C
	
		// Properties
		public bool isShow { /* [XID] */ /* 0x000000018987CC90-0x000000018987CCB0 */ get => default; /* [XID] */ /* 0x0000000189883BF0-0x0000000189883C10 */ set {} } // 0x0000000184926BC0-0x0000000184926C60 0x0000000184926C60-0x0000000184926D20
	
		// Constructors
		public MonoMapCursor() {} // 0x0000000184926B20-0x0000000184926BC0
	
		// Methods
		// [XID] // 0x0000000189874F50-0x0000000189874F70
		private void Awake() {} // 0x0000000184926570-0x0000000184926720
		// [XID] // 0x000000018988B2D0-0x000000018988B2F0
		public void AttachToMark(MonoMapMark target, bool multiple) {} // 0x0000000184926390-0x0000000184926570
		// [XID] // 0x0000000189892A10-0x0000000189892A30
		public void RefreshView() {} // 0x0000000184926720-0x00000001849269F0
		// [XID] // 0x000000018989A0B0-0x000000018989A0D0
		public void TriggerAnim(bool multiple) {} // 0x00000001849269F0-0x0000000184926B20
	}
}
