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
	public class MonoStarRate : MonoBehaviour // TypeDefIndex: 30482
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _stars; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _newStars; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _customActiveColor; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _useDefaultColor; // 0x38
		private int _maxStarNum; // 0x3C
	
		// Properties
		public int maxStarNum { /* [XID] */ /* 0x000000018991B7A0-0x000000018991B7C0 */ set {} } // 0x0000000185008F30-0x0000000185008FE0
		public int star { /* [XID] */ /* 0x0000000189922D60-0x0000000189922D80 */ set {} } // 0x0000000185008FE0-0x00000001850094C0
	
		// Constructors
		public MonoStarRate() {} // 0x0000000185008EC0-0x0000000185008F30
	
		// Methods
		// [XID] // 0x000000018992A650-0x000000018992A670
		public void Setup(int prevStar, int currStar) {} // 0x0000000185008C10-0x0000000185008EC0
		// [XID] // 0x0000000189931C20-0x0000000189931C40
		public void SetStarWithoutMax(int starNum) {} // 0x0000000185008B50-0x0000000185008C10
	}
}
