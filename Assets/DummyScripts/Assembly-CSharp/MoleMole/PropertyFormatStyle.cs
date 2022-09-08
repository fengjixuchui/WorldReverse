/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189AF2AF0-0x0000000189AF2B30
	public class PropertyFormatStyle : ScriptableObject // TypeDefIndex: 19654
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Style> _styles; // 0x18
		// [Header] // 0x0000000189B030B0-0x0000000189B030F0
		[SerializeField] // 0x0000000189B030B0-0x0000000189B030F0
		private List<FightPropType> _briefInfo; // 0x20
		// [Header] // 0x0000000189B0EE10-0x0000000189B0EE50
		[SerializeField] // 0x0000000189B0EE10-0x0000000189B0EE50
		private List<PropShowStruct> _basicsInfo; // 0x28
		// [Header] // 0x0000000189B1AC20-0x0000000189B1AC60
		[SerializeField] // 0x0000000189B1AC20-0x0000000189B1AC60
		private List<PropShowStruct> _advancedInfo; // 0x30
		// [Header] // 0x0000000189B26B90-0x0000000189B26BE0
		[SerializeField] // 0x0000000189B26B90-0x0000000189B26BE0
		private List<PropShowStruct> _elementInfo; // 0x38
		private Dictionary<FightPropType, Style> _styleDic; // 0x40
	
		// Properties
		public List<FightPropType> briefInfo { /* [XID] */ /* 0x0000000189B49040-0x0000000189B49060 */ get => default; } // 0x0000000183BAE3B0-0x0000000183BAE450 
		public List<PropShowStruct> basicsInfo { /* [XID] */ /* 0x0000000189B50640-0x0000000189B50660 */ get => default; } // 0x0000000183BAE310-0x0000000183BAE3B0 
		public List<PropShowStruct> advancedInfo { /* [XID] */ /* 0x0000000189B57FA0-0x0000000189B57FC0 */ get => default; } // 0x0000000183BAE270-0x0000000183BAE310 
		public List<PropShowStruct> elementInfo { /* [XID] */ /* 0x0000000189B5F920-0x0000000189B5F940 */ get => default; } // 0x0000000183BAE450-0x0000000183BAE4F0 
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19655
		{
			// Fields
			public FightPropType propType; // 0x00
			public PropFormat propFormat; // 0x04
			// [Tooltip] // 0x0000000189B67050-0x0000000189B67080
			public string spriteName; // 0x08
		}
	
		[Serializable]
		public struct PropShowStruct // TypeDefIndex: 19656
		{
			// Fields
			public PropShowType showType; // 0x00
			public FightPropType baseProp; // 0x04
			public FightPropType finalProp; // 0x08
		}
	
		// Constructors
		public PropertyFormatStyle() {} // 0x0000000183BAE1E0-0x0000000183BAE270
	
		// Methods
		// [XID] // 0x0000000189B324C0-0x0000000189B324E0
		private void OnEnable() {} // 0x0000000183BAE040-0x0000000183BAE1E0
		// [XID] // 0x0000000189B39D70-0x0000000189B39D90
		public PropFormat GetFormat(FightPropType propType) => default; // 0x0000000183BADD10-0x0000000183BADEA0
		// [XID] // 0x0000000189B41650-0x0000000189B41670
		public string GetSpriteName(FightPropType propType) => default; // 0x0000000183BADEA0-0x0000000183BAE040
	}
}
