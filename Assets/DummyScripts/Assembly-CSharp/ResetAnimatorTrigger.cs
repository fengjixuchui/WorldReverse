/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ResetAnimatorTrigger : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16484
{
	// Fields
	private string _triggerID; // 0x68

	// Properties
	public string triggerID { /* [XID] */ /* 0x00000001899C5E10-0x00000001899C5E30 */ get => default; /* [XID] */ /* 0x00000001899CD550-0x00000001899CD570 */ private set {} } // 0x000000018316F630-0x000000018316F6D0 0x0000000183170760-0x0000000183170810
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A5F1D0-0x0000000189A5F1F0 */ get => default; } // 0x0000000183170000-0x00000001831700A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A66A60-0x0000000189A66A80 */ get => default; } // 0x000000018316F590-0x000000018316F630 

	// Constructors
	public ResetAnimatorTrigger() {} // 0x0000000183170950-0x00000001831709B0

	// Methods
	// [XID] // 0x00000001899D4A50-0x00000001899D4A70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183170670-0x0000000183170760
	// [XID] // 0x00000001899DC050-0x00000001899DC070
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183170100-0x00000001831701E0
	// [XID] // 0x00000001899E39D0-0x00000001899E39F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CE0 */) => default; // 0x000000018316FC70-0x000000018316FD50
	// [XID] // 0x00000001899EAE00-0x00000001899EAE20
	public override int GetHashNum() => default; // 0x000000018316E770-0x000000018316E840
	// [XID] // 0x00000001899F2A60-0x00000001899F2A80
	public override void InitEmpty() {} // 0x000000018316F6D0-0x000000018316F7A0
	[BlackList] // 0x00000001899F9F50-0x00000001899F9F90
	// [XID] // 0x00000001899F9F50-0x00000001899F9F90
	public override bool FromJson(JSONNode node) => default; // 0x000000018316EE60-0x000000018316F1E0
	// [XID] // 0x0000000189A044D0-0x0000000189A044F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018316DF90-0x000000018316E1C0
	[BlackList] // 0x0000000189A0BBB0-0x0000000189A0BBF0
	// [XID] // 0x0000000189A0BBB0-0x0000000189A0BBF0
	public static new ResetAnimatorTrigger ParseFromJson(JSONNode node) => default; // 0x000000018316FDB0-0x0000000183170000
	// [XID] // 0x0000000189A16220-0x0000000189A16240
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CE1 */, bool useObjectPool = false /* Metadata: 0x00AF3CE5 */) => default; // 0x000000018316F970-0x000000018316FC70
	// [XID] // 0x0000000189A1D7C0-0x0000000189A1D7E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CE6 */, bool useObjectPool = false /* Metadata: 0x00AF3CEA */) => default; // 0x000000018316E990-0x000000018316EC00
	// [XID] // 0x0000000189A24B70-0x0000000189A24B90
	public static new ResetAnimatorTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CEB */, bool useObjectPool = false /* Metadata: 0x00AF3CEF */) => default; // 0x000000018316F290-0x000000018316F4B0
	[BlackList] // 0x0000000189A2C210-0x0000000189A2C250
	// [XID] // 0x0000000189A2C210-0x0000000189A2C250
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018316E1C0-0x000000018316E490
	// [XID] // 0x0000000189A36D10-0x0000000189A36D30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831702C0-0x00000001831704C0
	[BlackList] // 0x0000000189A3E2D0-0x0000000189A3E310
	// [XID] // 0x0000000189A3E2D0-0x0000000189A3E310
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018316F880-0x000000018316F970
	// [XID] // 0x0000000189A48950-0x0000000189A48970
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183170810-0x00000001831708B0
	// [XID] // 0x0000000189A500C0-0x0000000189A500E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018316EC00-0x000000018316ED60
	// [XID] // 0x0000000189A57690-0x0000000189A576B0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x00000001831704C0-0x0000000183170670
	[BlackList] // 0x0000000189A6E380-0x0000000189A6E3C0
	// [XID] // 0x0000000189A6E380-0x0000000189A6E3C0
	public override void AutoAllocTypeFields() {} // 0x000000018316E490-0x000000018316E530
	[BlackList] // 0x0000000189A78CC0-0x0000000189A78D00
	// [XID] // 0x0000000189A78CC0-0x0000000189A78D00
	public override void AutoRecycleTypeFields() {} // 0x000000018316E530-0x000000018316E5E0
	[BlackList] // 0x0000000189A83560-0x0000000189A835A0
	// [XID] // 0x0000000189A83560-0x0000000189A835A0
	public override void ReturnToObjectPool() {} // 0x00000001831708B0-0x0000000183170950
}

