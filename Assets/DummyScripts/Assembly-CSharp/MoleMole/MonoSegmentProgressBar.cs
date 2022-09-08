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
	public class MonoSegmentProgressBar : MonoBehaviour // TypeDefIndex: 31264
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _pointList; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _slider; // 0x20
	
		// Properties
		public MonoReusableList pointList { /* [XID] */ /* 0x0000000189772600-0x0000000189772620 */ get => default; } // 0x0000000184116080-0x0000000184116120 
		public Slider slider { /* [XID] */ /* 0x0000000189779C10-0x0000000189779C30 */ get => default; } // 0x0000000184116120-0x00000001841161C0 
		public float progressRatio { /* [XID] */ /* 0x0000000189781830-0x0000000189781850 */ set {} } // 0x00000001841161C0-0x00000001841162C0
	
		// Constructors
		public MonoSegmentProgressBar() {} // 0x0000000184116010-0x0000000184116080
	
		// Methods
		// [XID] // 0x0000000189788D30-0x0000000189788D50
		public MonoReusableListItem AddPointAt(float ratio) => default; // 0x0000000184115E10-0x0000000184116010
	}
}
