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

public sealed class TeamManager : GlobalManager // TypeDefIndex: 21013
{
	// Fields
	public TeamValue teamValue; // 0x10
	private List<ElementType> teamElementTypes; // 0x18
	public uint curTeamId; // 0x20
	public int curTeamSelectIndex; // 0x24
	private Dictionary<uint, List<ulong>> _teamDataMap; // 0x28
	private Dictionary<uint, string> _teamNames; // 0x30
	private List<ulong> _allAvatars; // 0x38
	private List<ulong> _filterAvatarList; // 0x40
	private List<ulong> EMPTY_TEAM; // 0x48
	private Dictionary<RadarHintType, bool> _radarHintMap; // 0x50
	public Action onTeamChanged; // 0x58
	private List<ulong> _tempAvatars; // 0x60
	private BaseEntity _teamEntity; // 0x68
	private LCTeam _lcTeam; // 0x70
	private uint maxAvatarLevel; // 0x78
	private List<ulong> _curTeamList; // 0x80
	private List<ulong> _bigTeamList; // 0x88
	private Dictionary<uint, List<ulong>> _bigTeamDictByPlayerUid; // 0x90
	private uint _frameTeamReferenceAvatarLevel; // 0x98
	private bool _frameTeamReferenceAvatarLevelDirty; // 0x9C
	private uint _frameTeamReferenceLocalAvatarAverageLevel; // 0xA0
	private bool _frameTeamReferenceLocalAvatarAverageLevelDirty; // 0xA4
	private uint _frameTeamReferenceAvatarAverageLevel; // 0xA8
	private bool _frameTeamReferenceAvatarAverageLevelDirty; // 0xAC
	private List<uint> _bigworldPlayers; // 0xB0
	private List<ulong> _bigWorldMultiplayerTeam; // 0xB8
	private List<MPTeamAvatarData> _bigworldMultiplayerTeamData; // 0xC0
	private List<uint> _dungeonPlayers; // 0xC8
	private List<ulong> _dungeonMultiplayerTeam; // 0xD0
	private List<MPTeamAvatarData> _dungeonMultiplayerTeamData; // 0xD8
	private static int[] _firstAvatarIndex; // 0x00
	private static int[] _secondAvatarIndex; // 0x08
	private Prioriter _prioriter; // 0xE0
	private SortType _sortType; // 0xE8

	// Properties
	public List<ulong> TempAvatars { /* [XID] */ /* 0x00000001897936A0-0x00000001897936C0 */ get => default; } // 0x0000000181BA04B0-0x0000000181BA0550 
	public List<ulong> curTeamList { /* [XID] */ /* 0x00000001897DF610-0x00000001897DF630 */ get => default; } // 0x0000000181BA3D50-0x0000000181BA3E20 
	public List<ulong> bigTeamList { /* [XID] */ /* 0x00000001897E6E30-0x00000001897E6E50 */ get => default; } // 0x0000000181BA0BB0-0x0000000181BA0C60 
	public Dictionary<uint, List<ulong>> bigTeamDictByPlayerUid { /* [XID] */ /* 0x00000001896DA4D0-0x00000001896DA4F0 */ get => default; } // 0x0000000181BA3700-0x0000000181BA37B0 
	public List<ulong> curOwnTeamList { /* [XID] */ /* 0x0000000189731EA0-0x0000000189731EC0 */ get => default; } // 0x0000000181BA0F90-0x0000000181BA1070 
	public uint curTeamReferenceAvatarLevel { /* [XID] */ /* 0x00000001898050D0-0x00000001898050F0 */ get => default; } // 0x0000000181BA1240-0x0000000181BA12F0 
	public uint curTeamReferenceAvatarLevelAverage { /* [XID] */ /* 0x000000018980C610-0x000000018980C630 */ get => default; } // 0x0000000181BA24E0-0x0000000181BA26F0 
	public uint frameTeamReferenceAvatarLevel { /* [XID] */ /* 0x0000000189813D80-0x0000000189813DA0 */ get => default; } // 0x0000000181BA3E20-0x0000000181BA3EE0 
	public uint frameTeamReferenceLocalAvatarAverageLevel { /* [XID] */ /* 0x000000018981B900-0x000000018981B920 */ get => default; } // 0x0000000181BA4370-0x0000000181BA4430 
	public uint frameTeamReferenceAvatarAverageLevel { /* [XID] */ /* 0x0000000189822EB0-0x0000000189822ED0 */ get => default; } // 0x0000000181BA0830-0x0000000181BA08F0 
	public List<ulong> allAvatars { /* [XID] */ /* 0x0000000189839260-0x0000000189839280 */ get => default; } // 0x0000000181BA3CB0-0x0000000181BA3D50 
	public List<ulong> bigworldMultiplayerTeam { /* [XID] */ /* 0x0000000189920210-0x0000000189920230 */ get => default; } // 0x0000000181B9E0F0-0x0000000181B9E1A0 
	public List<MPTeamAvatarData> bigworldMultiplayerTeamData { /* [XID] */ /* 0x0000000189927A50-0x0000000189927A70 */ get => default; } // 0x0000000181BA3EE0-0x0000000181BA3F90 
	public List<ulong> dungeonMultiplayerTeam { /* [XID] */ /* 0x000000018992F200-0x000000018992F220 */ get => default; } // 0x0000000181BA1F30-0x0000000181BA1FE0 
	public List<MPTeamAvatarData> dungeonMultiplayerTeamData { /* [XID] */ /* 0x00000001899365F0-0x0000000189936610 */ get => default; } // 0x0000000181BA1650-0x0000000181BA1700 
	public List<uint> currTeamPlayers { /* [XID] */ /* 0x000000018993E090-0x000000018993E0B0 */ get => default; } // 0x0000000181BA3430-0x0000000181BA3580 
	public List<ulong> currMultiplayerTeamList { /* [XID] */ /* 0x00000001899457A0-0x00000001899457C0 */ get => default; } // 0x0000000181BA0C60-0x0000000181BA0D70 
	public List<MPTeamAvatarData> currMPTeamDataList { /* [XID] */ /* 0x000000018994CC10-0x000000018994CC30 */ get => default; } // 0x0000000181BA1BF0-0x0000000181BA1D00 

	// Nested types
	public delegate bool Prioriter(ulong x); // TypeDefIndex: 21014; 0x0000000181BA8BE0-0x0000000181BA8D70

	// Constructors
	public TeamManager() {} // 0x0000000181BA4A00-0x0000000181BA4D40
	static TeamManager() {} // 0x0000000181BA4920-0x0000000181BA4A00

	// Methods
	// [XID] // 0x000000018979B8D0-0x000000018979B8F0
	public void SetTempAvatars(RepeatedField<ulong> avatarList) {} // 0x0000000181BA1D00-0x0000000181BA1E50
	// [XID] // 0x00000001897A2D00-0x00000001897A2D20
	public void SetLocalTeamEntity(BaseEntity teamEntity) {} // 0x0000000181BA05F0-0x0000000181BA06C0
	// [XID] // 0x00000001897AA300-0x00000001897AA320
	public List<ulong> GetAvatarList(AvatarType[] avatarTypeArray) => default; // 0x0000000181BA2D10-0x0000000181BA2F00
	// [XID] // 0x00000001897B1D90-0x00000001897B1DB0
	public List<ulong> GetAllFormalAvatar() => default; // 0x0000000181BA1FE0-0x0000000181BA2180
	// [XID] // 0x00000001897B9790-0x00000001897B97B0
	public void SetTeamName(uint teamID, string name) {} // 0x0000000181B9EFD0-0x0000000181B9F1C0
	// [XID] // 0x00000001897C17F0-0x00000001897C1810
	public string GetTeamName(uint teamID) => default; // 0x0000000181BA3A50-0x0000000181BA3B40
	// [XID] // 0x00000001897C9200-0x00000001897C9220
	public bool InCombat() => default; // 0x0000000181B9E450-0x0000000181B9E500
	// [XID] // 0x00000001897D0830-0x00000001897D0850
	public void UpdateMaxAvatarLevel() {} // 0x0000000181BA06C0-0x0000000181BA0830
	// [XID] // 0x00000001897D8540-0x00000001897D8560
	public uint GetMaxAvatarLevel() => default; // 0x0000000181BA39B0-0x0000000181BA3A50
	// [XID] // 0x00000001897F6240-0x00000001897F6260
	public void SetSceneTeamList(IList<SceneTeamAvatar> teamList) {} // 0x0000000181B9F2B0-0x0000000181B9FB40
	// [XID] // 0x000000018982A810-0x000000018982A830
	private uint GetLocalTeamAverageLevel() => default; // 0x0000000181BA3230-0x0000000181BA3430
	// [XID] // 0x0000000189831C00-0x0000000189831C20
	private uint GetTeamAverageLevel() => default; // 0x0000000181BA37B0-0x0000000181BA39B0
	// [XID] // 0x00000001898408B0-0x00000001898408D0
	public override void Init() {} // 0x0000000181BA2440-0x0000000181BA24E0
	// [XID] // 0x0000000189847E00-0x0000000189847E20
	public void FrameReset() {} // 0x0000000181B9ED40-0x0000000181B9EDF0
	// [XID] // 0x000000018984F580-0x000000018984F5A0
	public void Reset() {} // 0x0000000181BA0120-0x0000000181BA0330
	// [XID] // 0x0000000189856760-0x0000000189856780
	public override void ReloadRes() {} // 0x0000000181BA4880-0x0000000181BA4920
	// [XID] // 0x000000018985DA10-0x000000018985DA30
	private void Refresh() {} // 0x0000000181B9E1A0-0x0000000181B9E450
	// [XID] // 0x00000001898654D0-0x00000001898654F0
	public override void ClearOnLevelDestroy() {} // 0x0000000181BA0040-0x0000000181BA0120
	// [XID] // 0x000000018986C8F0-0x000000018986C910
	public override void ClearOnDisconnect() {} // 0x0000000181B9FFA0-0x0000000181BA0040
	// [XID] // 0x0000000189873DA0-0x0000000189873DC0
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFECBB */) {} // 0x0000000181B9FEF0-0x0000000181B9FFA0
	// [XID] // 0x000000018987B840-0x000000018987B860
	public List<ElementType> GetTeamElementTypes() => default; // 0x0000000181BA12F0-0x0000000181BA1390
	// [XID] // 0x00000001898829F0-0x0000000189882A10
	public void SetCurTeamId(uint teamId) {} // 0x0000000181BA2850-0x0000000181BA29A0
	// [XID] // 0x000000018988A190-0x000000018988A1B0
	public List<ulong> GetTeamList(uint teamId) => default; // 0x0000000181BA1390-0x0000000181BA14A0
	// [XID] // 0x0000000189891640-0x0000000189891660
	private List<ulong> CreateTeamList(uint teamId) => default; // 0x0000000181BA29A0-0x0000000181BA2AF0
	// [XID] // 0x0000000189898E70-0x0000000189898E90
	public List<uint> GetCurTeamEntityIDList() => default; // 0x0000000181BA2180-0x0000000181BA2440
	// [XID] // 0x00000001898A0070-0x00000001898A0090
	public List<uint> GetBigTeamEntityIDList() => default; // 0x0000000181BA08F0-0x0000000181BA0BB0
	// [XID] // 0x00000001898A7870-0x00000001898A7890
	public void AddAvatar(ulong guid) {} // 0x0000000181BA1970-0x0000000181BA1A60
	// [XID] // 0x00000001898AF330-0x00000001898AF350
	public void RemoveAvatar(ulong guid) {} // 0x0000000181BA2F00-0x0000000181BA3130
	// [XID] // 0x00000001898B67B0-0x00000001898B67D0
	public void ClearTeam(uint teamId) {} // 0x0000000181BA3130-0x0000000181BA3230
	// [XID] // 0x00000001898BDFC0-0x00000001898BDFE0
	public void AddTeamMember(uint teamId, ulong guid) {} // 0x0000000181B9DF70-0x0000000181B9E0F0
	// [XID] // 0x00000001898C5850-0x00000001898C5870
	public bool IsCointainsTeam(uint teamId) => default; // 0x0000000181BA1A60-0x0000000181BA1B30
	// [XID] // 0x00000001898CCF50-0x00000001898CCF70
	public int GetTeamCount() => default; // 0x0000000181B9EDF0-0x0000000181B9EEB0
	// [XID] // 0x00000001898D48F0-0x00000001898D4910
	public override void Destroy() {} // 0x0000000181BA0550-0x0000000181BA05F0
	// [XID] // 0x00000001898DC2B0-0x00000001898DC2D0
	public bool IsTeamAlive() => default; // 0x0000000181BA0330-0x0000000181BA04B0
	// [XID] // 0x00000001898E3CC0-0x00000001898E3CE0
	public uint GetAllCost() => default; // 0x0000000181BA14A0-0x0000000181BA1650
	// [XID] // 0x00000001898EB830-0x00000001898EB850
	public int GetLocalAvatarTeamIndex() => default; // 0x0000000181B9EEB0-0x0000000181B9EFD0
	// [XID] // 0x00000001898F30A0-0x00000001898F30C0
	public bool CheckWeaponCostNotOver(ulong selectedGuid, ulong avatarGuid) => default; // 0x0000000181BA3580-0x0000000181BA3700
	// [XID] // 0x00000001898FA740-0x00000001898FA760
	public int GetWeaponCostAdd(ulong selectedGuid, ulong avatarGuid) => default; // 0x0000000181BA4430-0x0000000181BA4880
	// [XID] // 0x0000000189902130-0x0000000189902150
	public bool CheckTeamCostNotOver(ulong currGuid, ulong selectedGuid) => default; // 0x0000000181BA1070-0x0000000181BA1240
	// [XID] // 0x00000001899098C0-0x00000001899098E0
	public int GetTeamCostAdd(ulong currGuid, ulong selectedGuid) => default; // 0x0000000181B9FB40-0x0000000181B9FEF0
	// [XID] // 0x0000000189910F30-0x0000000189910F50
	public bool IsMalePlayer() => default; // 0x0000000181BA1700-0x0000000181BA1970
	// [XID] // 0x0000000189918A50-0x0000000189918A70
	public bool CurrTeamContainsElementType(ElementType elementType) => default; // 0x0000000181BA0D70-0x0000000181BA0F90
	// [XID] // 0x0000000189954390-0x00000001899543B0
	private void ArrangeTeamData(List<uint> uids, List<ulong> team, List<MPTeamAvatarData> teamData) {} // 0x0000000181BA3FF0-0x0000000181BA4370
	// [XID] // 0x000000018995BCE0-0x000000018995BD00
	private void PadingTeamData(List<MPTeamAvatarData> teamData, int targetCount, uint playerUID, bool isAuthority) {} // 0x0000000181BA3B40-0x0000000181BA3CB0
	// [XID] // 0x0000000189963800-0x0000000189963820
	public ulong GetMPTeamFirstAvatar(int playerCount, int playerIndex) => default; // 0x0000000181BA2AF0-0x0000000181BA2C90
	// [XID] // 0x000000018996AC40-0x000000018996AC60
	public ulong GetMPTeamSecondAvatar(int playerCount, int playerIndex) => default; // 0x0000000181B9E500-0x0000000181B9E6A0
	// [XID] // 0x0000000189972890-0x00000001899728B0
	public void SortAvatarList(List<ulong> avatarList, SortType sortType, bool isAsce = false /* Metadata: 0x00AFECBC */, Prioriter prioriter = null) {} // 0x0000000181BA26F0-0x0000000181BA2850
	// [XID] // 0x000000018997A030-0x000000018997A050
	private int CompareAvatarItem(ulong x, ulong y) => default; // 0x0000000181B9E6A0-0x0000000181B9ED40
	// [XID] // 0x0000000189981780-0x00000001899817A0
	public void InitRadarHint() {} // 0x0000000181BA1B30-0x0000000181BA1BF0
	// [XID] // 0x0000000189989070-0x0000000189989090
	public bool RadarHintEnabled(RadarHintType type) => default; // 0x0000000181B9F1C0-0x0000000181B9F2B0
	// [XID] // 0x0000000189990850-0x0000000189990870
	public void SetRadarHintEnable(RadarHintType type, bool enable) {} // 0x0000000181BA1E50-0x0000000181BA1F30
}

