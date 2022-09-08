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

public sealed class VCWeather : VCBase // TypeDefIndex: 11975
{
	// Fields
	public string shapeName; // 0x108
	public ConfigWeather configWeather; // 0x110
	private EnviroWeatherPreset curWeather; // 0x118
	private EnviroWeatherPreset lastEffectWeather; // 0x120
	private LevelSceneSurfacePlugin _surfacePlugin; // 0x128
	private LevelSceneGrassPlugin _grassPlugin; // 0x130
	private ConfigGadget _config; // 0x138
	private uint _curCount; // 0x140
	private EntityTimer _energyTimer; // 0x148
	private int _roundCount; // 0x150
	private ConfigElemBall _curElemConfig; // 0x158
	private LCAbility _lcLevelAbility; // 0x160
	private ActorAbilityPlugin _levelAbilityPlugin; // 0x168
	private int lastTickIndex; // 0x170

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A43220-0x0000000189A43240 */ get => default; } // 0x0000000183797770-0x0000000183797810 

	// Constructors
	public VCWeather() {} // 0x00000001837976D0-0x0000000183797770

	// Methods
	// [XID] // 0x0000000189A4A6D0-0x0000000189A4A6F0
	public override void Init() {} // 0x0000000183795410-0x0000000183795670
	// [XID] // 0x0000000189A51F00-0x0000000189A51F20
	public override void OnEntityReady() {} // 0x00000001837966B0-0x0000000183796790
	// [XID] // 0x0000000189A597F0-0x0000000189A59810
	public override void Destroy() {} // 0x0000000183794570-0x00000001837946C0
	// [XID] // 0x0000000189A61030-0x0000000189A61050
	protected override void Tick(float inDeltaTime) {} // 0x0000000183797610-0x00000001837976D0
	// [XID] // 0x0000000189A68E90-0x0000000189A68EB0
	private void TickBuf() {} // 0x0000000183793840-0x0000000183793A10
	// [XID] // 0x0000000189A70140-0x0000000189A70160
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183795050-0x0000000183795130
	// [XID] // 0x0000000189A77920-0x0000000189A77940
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000183796790-0x00000001837968B0
	// [XID] // 0x0000000189A7F020-0x0000000189A7F040
	private void TickEnergy(float inDeltaTime) {} // 0x00000001837940F0-0x0000000183794220
	// [XID] // 0x0000000189A869C0-0x0000000189A869E0
	private void OnWeatherChanged(EnviroWeatherPreset weather) {} // 0x00000001837968B0-0x0000000183796A70
	// [XID] // 0x0000000189A8E5F0-0x0000000189A8E610
	private void OnWeatherEffectChanged(EnviroWeatherPreset to) {} // 0x00000001837959B0-0x0000000183795A80
	// [XID] // 0x0000000189A95A30-0x0000000189A95A50
	public void ClearEntity(bool force = true /* Metadata: 0x00AEB003 */) {} // 0x0000000183794030-0x00000001837940F0
	// [XID] // 0x0000000189A9D300-0x0000000189A9D320
	private void OnWeatherChangeFinish(EnviroWeatherPreset preWeather, EnviroWeatherPreset weather) {} // 0x0000000183793A10-0x0000000183793BC0
	// [XID] // 0x0000000189AA4A00-0x0000000189AA4A20
	private bool EntityAffectByEnviro(BaseEntity entity) => default; // 0x0000000183796E30-0x0000000183796F30
	// [XID] // 0x0000000189AAC050-0x0000000189AAC070
	private void RefreshEntities(EnviroWeatherPreset from, EnviroWeatherPreset to) {} // 0x0000000183794C10-0x0000000183794E20
	// [XID] // 0x0000000189AB39D0-0x0000000189AB39F0
	private void RefreshGrassEntities(EnviroWeatherPreset from, EnviroWeatherPreset to) {} // 0x00000001837962A0-0x00000001837966B0
	// [XID] // 0x0000000189ABB6F0-0x0000000189ABB710
	private void HandleEntityReady(uint entityID) {} // 0x0000000183795FA0-0x00000001837960A0
	// [XID] // 0x0000000189AC2DB0-0x0000000189AC2DD0
	private void ProcessWeatherToEntity(EnviroWeatherPreset from, EnviroWeatherPreset to, BaseEntity entity) {} // 0x0000000183795200-0x0000000183795410
	// [XID] // 0x000000018990C040-0x000000018990C060
	private void CheckCurrentWeatherToEntity(EnviroWeatherPreset current, BaseEntity entity) {} // 0x0000000183793BC0-0x0000000183793D30
	// [XID] // 0x0000000189AD1EA0-0x0000000189AD1EC0
	private bool IsEntityInOccluder(BaseEntity entity) => default; // 0x0000000183793E20-0x0000000183794030
	// [XID] // 0x000000018984BE50-0x000000018984BE70
	private void EnableRainModifier(bool enable, BaseEntity entity) {} // 0x00000001837948D0-0x0000000183794B90
	// [XID] // 0x0000000189AE15B0-0x0000000189AE15D0
	public void OneGWEntityEnter(BaseEntity entity) {} // 0x0000000183795130-0x0000000183795200
	// [XID] // 0x0000000189AE8A10-0x0000000189AE8A30
	public void ActiveEnvirArea(bool enable) {} // 0x0000000183796A70-0x0000000183796E30
	// [XID] // 0x0000000189AF0860-0x0000000189AF0880
	public void OneEntityEnterWeather(BaseEntity entity) {} // 0x0000000183794480-0x0000000183794570
	// [XID] // 0x0000000189AF7DD0-0x0000000189AF7DF0
	public void OneEntityExitWeather(BaseEntity entity) {} // 0x0000000183793D30-0x0000000183793E20
	// [XID] // 0x0000000189AFF3D0-0x0000000189AFF3F0
	public void DoThunderSkill() {} // 0x0000000183794E20-0x0000000183795050
	// [XID] // 0x0000000189B06B90-0x0000000189B06BB0
	public void ThunderOne(Vector3 beginPos, Vector3 endPos, bool isFar, bool genBall) {} // 0x00000001837946C0-0x00000001837948D0
	// [XID] // 0x0000000189B0E3D0-0x0000000189B0E3F0
	private void CheckElemEnergy(ElemBallTriggerType type, object param = null) {} // 0x0000000183794220-0x0000000183794480
	// [XID] // 0x0000000189B15570-0x0000000189B15590
	private void ResetElemEnergy() {} // 0x0000000183796190-0x0000000183796240
	// [XID] // 0x0000000189B1D010-0x0000000189B1D030
	private void CreateElemRound() {} // 0x0000000183796F30-0x0000000183797610
	// [XID] // 0x0000000189B24560-0x0000000189B24580
	private void DoCreateElemBall(object param) {} // 0x00000001837956D0-0x00000001837959B0
	// [XID] // 0x0000000189B2BA40-0x0000000189B2BA60
	private void GenerateElemBall(Vector3 pos) {} // 0x0000000183795A80-0x0000000183795FA0
}

