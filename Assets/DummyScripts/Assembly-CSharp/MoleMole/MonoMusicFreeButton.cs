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
	public class MonoMusicFreeButton : MonoActionBtn // TypeDefIndex: 31105
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _effectObj; // 0x58
		private Animator _btnAnimator; // 0x60
		public int index; // 0x68
		public Action<int> onClickCallback; // 0x70
		private ParticleSystem effect; // 0x78
	
		// Constructors
		public MonoMusicFreeButton() {} // 0x000000018370DDF0-0x000000018370DE80
	
		// Methods
		// [XID] // 0x0000000189910860-0x0000000189910880
		public void SimulatePointDown() {} // 0x000000018370DAA0-0x000000018370DC80
		// [XID] // 0x0000000189918440-0x0000000189918460
		public void SimulatePointUp() {} // 0x000000018370DC80-0x000000018370DDF0
		// [XID] // 0x000000018991FC60-0x000000018991FC80
		protected override void HandlePointDown() {} // 0x000000018370D890-0x000000018370DA40
	}
}
