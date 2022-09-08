/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityPreloader // TypeDefIndex: 32018
{
	// Fields
	protected BaseEntity _entity; // 0x10
	private ConfigPreloadType _preloadType; // 0x18
	private uint _entityRuntimeID; // 0x1C
	private EPreloadEntityType _epType; // 0x20
	private uint _checkHandle; // 0x24
	protected List<AsyncJob> _jobs; // 0x28
	protected HashSet<string> _asyncPreloading; // 0x38
	protected int _asyncPreloadingCount; // 0x40
	private Action _loadFinish; // 0x48
	private static string[] RESERVED_ENTITY_ASYNC_PRELOADING_MARK; // 0x00
	private static string RESERVED_ANIM_PATTERN_ASYNC_PRELOADING_MARK; // 0x08
	protected Action _asyncPreloadedCallback; // 0x50
	protected Action<AsyncJob> _addJob; // 0x58
	protected Action<string> _asyncPreloadedCallbackString; // 0x60
	public static string CONFIG_EXT; // 0x10
	private SpriteLoadProxy _spriteLoadProxy; // 0x68
	private Action _animPatternLoadedCallback; // 0x70

	// Properties
	public Status status { /* [XID] */ /* 0x0000000189801D30-0x0000000189801D70 */ get; /* [XID] */ /* 0x000000018980C050-0x000000018980C090 */ protected set; } // 0x000000018190E670-0x000000018190E6D0 0x0000000181913A40-0x0000000181913AA0
	private SpriteLoadProxy spriteLoadProxy { /* [XID] */ /* 0x00000001898FA170-0x00000001898FA190 */ get => default; } // 0x00000001819111A0-0x0000000181911270 

	// Nested types
	public enum Status // TypeDefIndex: 32019
	{
		Released = 0,
		Preloading = 1,
		Preloaded = 2
	}

	// Constructors
	public EntityPreloader() {} // Dummy constructor
	public EntityPreloader(BaseEntity entity, ConfigPreloadType preloadType) {} // 0x00000001819143E0-0x00000001819144E0
	static EntityPreloader() {} // 0x00000001819142C0-0x00000001819143E0

	// Methods
	// [XID] // 0x00000001897888E0-0x0000000189788900
	public void Preload(EPreloadEntityType preloadType = EPreloadEntityType.Default /* Metadata: 0x00B13B67 */) {} // 0x000000018190FCF0-0x00000001819100A0
	// [XID] // 0x00000001897548D0-0x00000001897548F0
	public string ToDebugString(string loaderName) => default; // 0x000000018190E9F0-0x000000018190EE20
	// [XID] // 0x0000000189825710-0x0000000189825730
	private bool CheckEntityAsyncLoadFinish(float time) => default; // 0x0000000181913AA0-0x00000001819142C0
	// [XID] // 0x0000000189689140-0x0000000189689160
	public void PreloadAsync(Action preloadedCallback, EPreloadEntityType preloadEntityType) {} // 0x0000000181912550-0x0000000181912A20
	// [XID] // 0x00000001899736D0-0x00000001899736F0
	protected virtual void AsyncPreloadOther() {} // 0x000000018190EED0-0x000000018190EF70
	// [IDTag] // 0x000000018983BD30-0x000000018983BD70
	// [XID] // 0x000000018983BD30-0x000000018983BD70
	protected void AsyncPreloadingCallback(string[] abilityPaths = null) {} // 0x00000001819113F0-0x0000000181911520
	// [IDTag] // 0x0000000189846330-0x0000000189846370
	// [XID] // 0x0000000189846330-0x0000000189846370
	protected void AsyncPreloadingCallback(string ability) {} // 0x0000000181911520-0x00000001819117B0
	// [IDTag] // 0x0000000189850630-0x0000000189850670
	// [XID] // 0x0000000189850630-0x0000000189850670
	private void AsyncPreloadedCallback() {} // 0x000000018190E6D0-0x000000018190E830
	// [IDTag] // 0x000000018985AC00-0x000000018985AC40
	// [XID] // 0x000000018985AC00-0x000000018985AC40
	protected void AsyncPreloadedCallback(string abilityPath) {} // 0x000000018190E830-0x000000018190E9F0
	// [XID] // 0x00000001897AE4F0-0x00000001897AE510
	protected void CheckPreloadAsyncFinish() {} // 0x0000000181911AD0-0x0000000181912030
	// [XID] // 0x0000000189B88740-0x0000000189B88760
	public void ReleasePreloaded() {} // 0x0000000181912100-0x0000000181912550
	// [XID] // 0x00000001898737D0-0x00000001898737F0
	protected virtual void ReleasePreloadOther() {} // 0x0000000181912E00-0x0000000181912EA0
	// [XID] // 0x00000001897BE2C0-0x00000001897BE2E0
	private void LoadFinish() {} // 0x000000018190EE20-0x000000018190EED0
	// [XID] // 0x00000001897EB010-0x00000001897EB030
	private void PreloadEffect() {} // 0x0000000181910690-0x0000000181910A00
	// [XID] // 0x0000000189A1F7F0-0x0000000189A1F810
	private void AsyncPreloadEffect() {} // 0x00000001819100A0-0x0000000181910360
	// [XID] // 0x0000000189891140-0x0000000189891160
	private void ReleasePreloadedEffect() {} // 0x0000000181912EA0-0x00000001819130D0
	// [XID] // 0x000000018985AA10-0x000000018985AA30
	private void PreloadAbility() {} // 0x000000018190E340-0x000000018190E670
	// [XID] // 0x000000018989F940-0x000000018989F960
	private void AsyncPreloadAbility() {} // 0x0000000181910E90-0x00000001819111A0
	// [XID] // 0x00000001898A7320-0x00000001898A7340
	private void ReleasePreloadedAbility() {} // 0x0000000181913260-0x0000000181913450
	// [XID] // 0x00000001898AED40-0x00000001898AED60
	private void PreloadGadget() {} // 0x0000000181910360-0x0000000181910690
	// [XID] // 0x00000001898E80A0-0x00000001898E80C0
	private void AsyncPreloadGadget() {} // 0x0000000181911880-0x0000000181911AD0
	// [XID] // 0x0000000189AEF3D0-0x0000000189AEF3F0
	private void ReleasePreloadedGadget() {} // 0x000000018190E150-0x000000018190E340
	// [XID] // 0x00000001898C52E0-0x00000001898C5300
	private void PreloadCamera() {} // 0x00000001819130D0-0x0000000181913260
	// [XID] // 0x00000001898CC7D0-0x00000001898CC7F0
	private void AsyncPreloadCamera() {} // 0x0000000181912A20-0x0000000181912C70
	// [XID] // 0x00000001898D41F0-0x00000001898D4210
	private void ReleasePreloadedCamera() {} // 0x0000000181910D70-0x0000000181910E90
	// [XID] // 0x00000001898DBA10-0x00000001898DBA30
	private void PreloadDynamicAnimEventPattern() {} // 0x000000018190EF70-0x000000018190F130
	// [XID] // 0x00000001898E35F0-0x00000001898E3610
	private void AsyncPreloadDynamicAnimEventPattern() {} // 0x00000001819137C0-0x0000000181913A40
	// [XID] // 0x00000001898EB280-0x00000001898EB2A0
	protected void AddToJobList(AsyncJob job) {} // 0x00000001819117B0-0x0000000181911880
	// [XID] // 0x00000001898F29C0-0x00000001898F29E0
	private void ReleasePreloadedDynamicAnimEventPattern() {} // 0x000000018190F130-0x000000018190F290
	// [XID] // 0x0000000189BAE6F0-0x0000000189BAE710
	private void PreloadSkillIcons() {} // 0x0000000181911270-0x00000001819113F0
	// [XID] // 0x00000001899092D0-0x00000001899092F0
	private void AsyncPreloadSkillIcons() {} // 0x000000018190DFC0-0x000000018190E150
	// [XID] // 0x0000000189B1A110-0x0000000189B1A130
	private void ReleasePreloadedSkillIcons() {} // 0x0000000181912030-0x0000000181912100
	// [XID] // 0x0000000189918340-0x0000000189918360
	public void CheckJsonConfig() {} // 0x0000000181910A00-0x0000000181910D70
	// [XID] // 0x000000018991FBC0-0x000000018991FBE0
	private void PreloadJsonConfig(EPreloadEntityType preloadType) {} // 0x000000018190F290-0x000000018190F6F0
	// [XID] // 0x00000001898693C0-0x00000001898693E0
	private void AsyncPreloadJsonConfig(EPreloadEntityType preloadType) {} // 0x000000018190F6F0-0x000000018190FCF0
	// [XID] // 0x000000018992EBD0-0x000000018992EBF0
	private void PreloadEntityAnimPatternAsync() {} // 0x0000000181912C70-0x0000000181912E00
	// [XID] // 0x0000000189B5D5E0-0x0000000189B5D600
	private void ReleasePreloadedJsonConfig(EPreloadEntityType preloadType) {} // 0x0000000181913450-0x00000001819137C0
}

