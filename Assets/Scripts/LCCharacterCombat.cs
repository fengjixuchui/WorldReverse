/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCCharacterCombat : LCBaseCombat // TypeDefIndex: 11724
{
	// Fields
	private Dictionary<uint, SummonInfo> _summonInfos; // 0x1B0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896C4040-0x00000001896C4060 */ get => LCBaseComponentTypeIDs.LCCharacterCombat; } // 0x00000001833AB820-0x00000001833AB8C0 

	// Nested types
	public class SummonInfo // TypeDefIndex: 11725
	{
		// Fields
		public uint summonTag; // 0x10
		public int maxNum; // 0x14
		public int curNum; // 0x18

		// Constructors
		public SummonInfo() {} // 0x000000018339DBD0-0x000000018339DC30
	}

	// Constructors
	public LCCharacterCombat() {} // 0x00000001833AB7A0-0x00000001833AB820

	// Methods
	// [XID] // 0x0000000189695060-0x0000000189695080
	public override void PreInit() 
	{
		base.PreInit();
		InitSummonInfos();
	} // 0x00000001833AB6F0-0x00000001833AB7A0
	// [XID] // 0x0000000189709C40-0x0000000189709C60
	protected void InitSummonInfos() 
	{
		_summonInfos = default;
		if (_entity.jsonConfig == null)
		{
			_entity.jsonConfig = default;
		}
		else 
		{
			ConfigCharacter charaConfig = (_entity.jsonConfig as ConfigCharacter);
			if (!JsonTool.IsEmptyValue(charaConfig.combat)) 
			{
				if (!JsonTool.IsEmptyValue(configCombat.summon))
				{
					foreach (var tag in configCombat.summon.summonTags)
					{ 
						SummonInfo summonInfo = default;
						summonInfo.summonTag = tag.summonTag;
						summonInfo.maxNum = tag.maxNum;
						summonInfo.curNum = 0;
						_summonInfos.Add(summonInfo.summonTag, summonInfo);
					}
				}
			}
		}
	} // 0x00000001833AB1C0-0x00000001833AB520
	  // [XID] // 0x000000018967B3E0-0x000000018967B400
	public SummonInfo GetSummonInfo(uint summonTag)
	{
		if (_summonInfos.ContainsKey(summonTag))
		{
			return _summonInfos[summonTag];
		}
		return null;
	}// 0x00000001833AB520-0x00000001833AB620
	// [XID] // 0x00000001896AF680-0x00000001896AF6A0
	public void UdateSummonNum(uint summonTag, int num) 
	{
		if (_summonInfos.ContainsKey(summonTag))
		{
			_summonInfos[summonTag].curNum = Mathf.Clamp(num, 0, _summonInfos[summonTag].maxNum);
		}
	} // 0x00000001833AB030-0x00000001833AB1C0
}

