/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCEquipModel : VCBaseModel // TypeDefIndex: 11854
{
	// Fields
	[NonSerialized]
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	private VCAvatarEquipController _avatarEquipController; // 0x1E0
	private Animator _equipAnim; // 0x1E8
	private AnimatorControllerParameter[] _parameters; // 0x1F0
	private BaseEquipAnimPlugin _equipAnimPlugin; // 0x1F8
	private GameObject _normalObject; // 0x200
	private GameObject _normalObject2; // 0x208
	private Transform _effectMesh; // 0x210
	private int _effectIndex; // 0x218
	private Status _status; // 0x21C
	private bool _showImmediately; // 0x220
	private const float showSheatheEffectMinBright = 0.4f; // Metadata: 0x00AEAD2C
	public static bool forceHidePutawayWeapon; // 0x00
	private WeaponItem _equipItem; // 0x228
	private Texture[] _lastTextures; // 0x230
	private TimerReceiver _dissolveDelayAppearTimer; // 0x238
	private TimerReceiver _dissolveDelaySheatheTimer; // 0x240
	private float _dissolveBrightness; // 0x248
	private float _dissolveAppearSpeed; // 0x24C
	private float _dissolveSheatheSpeed; // 0x250
	private float DissolveDelayAppearTime; // 0x254
	private float DissolveTakeAppearSpeed; // 0x258
	private float DissolveSheatheAppearSpeed; // 0x25C
	private bool _hasPlayDoneParam; // 0x260
	private float _playTime; // 0x264
	private Texture[] _lastLightMapTextures; // 0x268
	private Coroutine _awakenTextureLoader; // 0x270
	private uint _awakenTextureHandle; // 0x278
	private Coroutine _awakenLightMapTextureLoader; // 0x280
	private uint _awakenLightMapTextureHandle; // 0x288
	private Coroutine _goldTextureLoader; // 0x290
	private uint _goldTextureHandle; // 0x298
	private string _texPath; // 0x2A0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189988370-0x0000000189988390 */ get => default; } // 0x000000018217A750-0x000000018217A7F0 
	private AnimatorControllerParameter[] parameters { /* [XID] */ /* 0x0000000189A5E360-0x0000000189A5E380 */ get => default; } // 0x0000000182175B40-0x0000000182175D30 
	public Status status { /* [XID] */ /* 0x0000000189601C30-0x0000000189601C50 */ get => default; } // 0x00000001821762E0-0x0000000182176380 

	// Nested types
	public enum Status // TypeDefIndex: 11855
	{
		None = 0,
		Show = 1,
		Hide = 2
	}

	// Constructors
	public VCEquipModel() {} // 0x000000018217A670-0x000000018217A750
	static VCEquipModel() {} // 0x000000018217A610-0x000000018217A670

	// Methods
	// [XID] // 0x00000001895FA2A0-0x00000001895FA2C0
	public BaseEquipAnimPlugin GetEquipAnimPlugin() => default; // 0x0000000182175A90-0x0000000182175B40
	// [XID] // 0x000000018991F7B0-0x000000018991F7D0
	public override void OnEntityReady() {} // 0x0000000182179B80-0x0000000182179C40
	// [XID] // 0x0000000189610BE0-0x0000000189610C00
	public void SetEquipController(VCBaseEquipController controller) {} // 0x00000001821769B0-0x0000000182176AA0
	// [XID] // 0x0000000189617EB0-0x0000000189617ED0
	public override void PreInit() {} // 0x000000018217A150-0x000000018217A3B0
	// [XID] // 0x000000018994C3C0-0x000000018994C3E0
	public override void Init() {} // 0x0000000182178040-0x0000000182178570
	// [XID] // 0x0000000189626E50-0x0000000189626E70
	private void ShowNormalObject() {} // 0x0000000182179610-0x00000001821797A0
	// [XID] // 0x000000018962E800-0x000000018962E820
	private void ShowEffectObject() {} // 0x0000000182179C40-0x0000000182179DD0
	// [XID] // 0x0000000189636460-0x0000000189636480
	private void HideAllObject() {} // 0x0000000182178ED0-0x0000000182179060
	// [XID] // 0x000000018963DA90-0x000000018963DAB0
	protected override void Tick(float inDeltaTime) {} // 0x000000018217A3B0-0x000000018217A610
	// [XID] // 0x0000000189645040-0x0000000189645060
	public override void Destroy() {} // 0x0000000182176FB0-0x0000000182177090
	// [XID] // 0x000000018964CB00-0x000000018964CB20
	public void ShowEquip(bool showImmediately, float? dissolveDelay = default, float? dissolveSpeed = default) {} // 0x0000000182175F90-0x0000000182176280
	// [XID] // 0x0000000189653F30-0x0000000189653F50
	public void HideEquip(float dissolveDelay, float dissolveSpeed) {} // 0x0000000182177EE0-0x0000000182178040
	// [XID] // 0x000000018965B930-0x000000018965B950
	public void HideEquipImmediately(bool showEffect) {} // 0x00000001821792E0-0x0000000182179400
	// [XID] // 0x00000001895E9D40-0x00000001895E9D60
	private void ShowWeaponSheatheEffect() {} // 0x00000001821778A0-0x0000000182177BA0
	// [XID] // 0x000000018966A810-0x000000018966A830
	private void ShowWeaponLoopEffect() {} // 0x0000000182176470-0x0000000182176770
	// [XID] // 0x00000001896724F0-0x0000000189672510
	private void StopWeaponLoofEffect() {} // 0x0000000182178CB0-0x0000000182178D80
	// [XID] // 0x0000000189679D60-0x0000000189679D80
	private void PlayAppearSound() {} // 0x0000000182176D70-0x0000000182176ED0
	// [XID] // 0x0000000189681420-0x0000000189681440
	protected override bool CheckVisible() => default; // 0x0000000182179DD0-0x0000000182179F50
	// [XID] // 0x0000000189688F40-0x0000000189688F60
	private void InitDissolve() {} // 0x0000000182178D80-0x0000000182178ED0
	// [XID] // 0x0000000189690A60-0x0000000189690A80
	private void DestroyDissolve() {} // 0x000000018217A000-0x000000018217A150
	// [XID] // 0x00000001896982C0-0x00000001896982E0
	private void OnEntityTimeScaleChange(EvtEntityTimeScaleChange evt) {} // 0x0000000182176380-0x0000000182176470
	// [XID] // 0x000000018969F560-0x000000018969F580
	private void DoDissolveDelayAppear(float dissolveDelayAppearTime, float dissolveAppearSpeed, float dissolveBrightness) {} // 0x00000001821799C0-0x0000000182179B80
	// [XID] // 0x00000001896A6920-0x00000001896A6940
	private bool DoDissolveDelayAppearFinish() => default; // 0x0000000182178690-0x0000000182178740
	// [XID] // 0x00000001896AE010-0x00000001896AE030
	private bool IsDissolveDelayAppearing() => default; // 0x00000001821771B0-0x0000000182177290
	// [XID] // 0x00000001896B5680-0x00000001896B56A0
	private void DoDissolveDelaySheathe(float dissolveDelaySheatheTime, float dissolveSheatheSpeed, float dissolveBrightness) {} // 0x0000000182179800-0x00000001821799C0
	// [XID] // 0x0000000189BDD2D0-0x0000000189BDD2F0
	private bool DoDissolveDelaySheatheFinish() => default; // 0x0000000182179F50-0x000000018217A000
	// [XID] // 0x00000001896C3E80-0x00000001896C3EA0
	private bool IsDissolveDelaySheathing() => default; // 0x0000000182176ED0-0x0000000182176FB0
	// [XID] // 0x00000001896CB350-0x00000001896CB370
	private void UpdateBrightness(float deltaTime) {} // 0x0000000182177BA0-0x0000000182177EE0
	// [XID] // 0x00000001896D2910-0x00000001896D2930
	private void UpdateAnimatorTrigger() {} // 0x00000001821789D0-0x0000000182178C40
	// [XID] // 0x0000000189989FB0-0x0000000189989FD0
	public void SetAnimatorTrigger(string triggerName, float playTime) {} // 0x0000000182176770-0x00000001821769B0
	// [XID] // 0x0000000189B4B180-0x0000000189B4B1A0
	public void SetAnimatorFloat(string paramName, float value) {} // 0x00000001821773B0-0x00000001821774D0
	// [XID] // 0x00000001896E8F30-0x00000001896E8F50
	private void CheckAwakenTexture() {} // 0x0000000182179190-0x00000001821792E0
	// [XID] // 0x00000001896F0170-0x00000001896F0190
	private void OnUseAwakenTexture() {} // 0x0000000182179470-0x0000000182179610
	// [XID] // 0x00000001899BD3E0-0x00000001899BD400
	public void LoadAwakenTexture(string awakenTexture, string awakenLightMapTexture) {} // 0x00000001821776B0-0x00000001821778A0
	// [XID] // 0x00000001896FF510-0x00000001896FF530
	public void LoadLastTexture() {} // 0x0000000182175D30-0x0000000182175F90
	[DebuggerHidden] // 0x00000001897068A0-0x00000001897068E0
	// [XID] // 0x00000001897068A0-0x00000001897068E0
	private IEnumerator LoadTextureResource(string texturePath) => default; // 0x0000000182178570-0x0000000182178690
	[DebuggerHidden] // 0x0000000189711410-0x0000000189711450
	// [XID] // 0x0000000189711410-0x0000000189711450
	private IEnumerator LoadLightMapTextureResource(string lightMapTexturePath) => default; // 0x0000000182177290-0x00000001821773B0
	// [XID] // 0x000000018971BA70-0x000000018971BA90
	private void DestroyAwakenTexture() {} // 0x0000000182176AA0-0x0000000182176D70
	// [XID] // 0x0000000189722DF0-0x0000000189722E10
	private void CheckGold() {} // 0x0000000182177550-0x00000001821776B0
	// [XID] // 0x000000018972A400-0x000000018972A420
	private void OnGoldWeapon() {} // 0x0000000182179060-0x0000000182179190
	[DebuggerHidden] // 0x0000000189731CC0-0x0000000189731D00
	// [XID] // 0x0000000189731CC0-0x0000000189731D00
	private IEnumerator LoadGoldTextureResource(string texturePath) => default; // 0x0000000182177090-0x00000001821771B0
	// [XID] // 0x000000018973C740-0x000000018973C760
	private void DestroyGoldTexture() {} // 0x0000000182178800-0x00000001821789D0
}

