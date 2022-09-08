/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityTileAttackManagerMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14580
{
	// Fields
	private TileAttackManagerMixin _config; // 0x70
	private LevelTileAttackPlugin _tilePlugin; // 0x78
	private NormalTimer _normalTimer; // 0x80
	private const int MaxAttackeeNum = 128; // Metadata: 0x00AEB913
	private BaseEntity[] _attackees; // 0x88
	private LCBaseCombat _lcAttackerCombat; // 0x90
	private LCAbility _lcAttackerAbility; // 0x98

	// Constructors
	public AbilityTileAttackManagerMixin() {} // 0x0000000184FC0680-0x0000000184FC06E0

	// Methods
	// [XID] // 0x0000000189907560-0x0000000189907580
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184FBEB30-0x0000000184FBED30
	// [XID] // 0x000000018990EE90-0x000000018990EEB0
	public override void Clear() {} // 0x0000000184FBEE20-0x0000000184FBEED0
	// [XID] // 0x0000000189916740-0x0000000189916760
	protected override void AddEventListener() {} // 0x0000000184FBE7A0-0x0000000184FBE8D0
	// [XID] // 0x000000018991DEF0-0x000000018991DF10
	protected override void RemoveEventListener() {} // 0x0000000184FBF070-0x0000000184FBF1A0
	// [XID] // 0x00000001899257E0-0x0000000189925800
	public override void OnAdded(bool syncToServer) {} // 0x0000000184FBE4D0-0x0000000184FBE5A0
	// [XID] // 0x000000018992CC50-0x000000018992CC70
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184FBE9B0-0x0000000184FBEA60
	// [XID] // 0x0000000189934180-0x00000001899341A0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000184FBEED0-0x0000000184FBEFB0
	// [XID] // 0x000000018993BE90-0x000000018993BEB0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000184FBF510-0x0000000184FBF5F0
	// [XID] // 0x00000001899431F0-0x0000000189943210
	public void UpdateGlobalValues() {} // 0x0000000184FBEA60-0x0000000184FBEB30
	// [XID] // 0x000000018994A980-0x000000018994A9A0
	public override void Tick(float inDeltaTime) {} // 0x0000000184FC0500-0x0000000184FC0680
	// [XID] // 0x00000001899523F0-0x0000000189952410
	private void InitTileManager() {} // 0x0000000184FBF400-0x0000000184FBF510
	// [XID] // 0x0000000189959890-0x00000001899598B0
	private void DoAttackAction() {} // 0x0000000184FBFC80-0x0000000184FC0460
	// [XID] // 0x00000001899610F0-0x0000000189961110
	public void UpdateBaseReactionDamage(string abilityName) {} // 0x0000000184FBF200-0x0000000184FBF400
	// [XID] // 0x0000000189968890-0x00000001899688B0
	private void TrySyncBaseReactionDamage(uint sourceCasterID, uint reactionType, string abilityName) {} // 0x0000000184FBF650-0x0000000184FBF8B0
	// [XID] // 0x000000018996FE60-0x000000018996FE80
	public override void OnBeforePoolRecycled() {} // 0x0000000184FBF970-0x0000000184FBFA90
	// [XID] // 0x0000000189977C50-0x0000000189977C70
	public override void OnPoolAllocated() {} // 0x0000000184FBFA90-0x0000000184FBFBA0
	[BlackList] // 0x000000018997EE50-0x000000018997EE90
	// [XID] // 0x000000018997EE50-0x000000018997EE90
	public override void AutoAllocTypeFields() {} // 0x0000000184FBE630-0x0000000184FBE6D0
	[BlackList] // 0x0000000189989BF0-0x0000000189989C30
	// [XID] // 0x0000000189989BF0-0x0000000189989C30
	public override void AutoRecycleTypeFields() {} // 0x0000000184FBE6D0-0x0000000184FBE7A0
	[BlackList] // 0x0000000189994760-0x00000001899947A0
	// [XID] // 0x0000000189994760-0x00000001899947A0
	public override void ReturnToObjectPool() {} // 0x0000000184FC0460-0x0000000184FC0500
}

