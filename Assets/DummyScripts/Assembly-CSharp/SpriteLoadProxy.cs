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
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SpriteLoadProxy // TypeDefIndex: 31562
{
	// Fields
	private DoublyList<uint> _loadedSprites; // 0x10
	private Dictionary<ulong, Sprite> _spriteCache; // 0x18
	private Dictionary<int, AsyncJob> _jobDic; // 0x20

	// Constructors
	public SpriteLoadProxy() {} // 0x0000000182821A60-0x0000000182821AC0

	// Methods
	// [XID] // 0x0000000189BCFBD0-0x0000000189BCFBF0
	private void PrepareList() {} // 0x000000018281FD10-0x000000018281FDF0
	// [XID] // 0x0000000189864EB0-0x0000000189864ED0
	private void AddHandler(uint handler) {} // 0x0000000182819FC0-0x000000018281A090
	// [XID] // 0x00000001897DAB50-0x00000001897DAB70
	public void Release() {} // 0x000000018281D3C0-0x000000018281D6E0
	// [IDTag] // 0x0000000189873850-0x0000000189873890
	// [XID] // 0x0000000189873850-0x0000000189873890
	public Sprite LoadSprite(ulong path) => default; // 0x0000000182821460-0x00000001828215E0
	// [IDTag] // 0x000000018987E440-0x000000018987E480
	// [XID] // 0x000000018987E440-0x000000018987E480
	public AsyncJob LoadSpriteAsync(ulong path, Action<Sprite> onResult) => default; // 0x000000018281F380-0x000000018281F5E0
	// [IDTag] // 0x00000001898885A0-0x00000001898885E0
	// [XID] // 0x00000001898885A0-0x00000001898885E0
	public void LoadSpriteAsync(ulong path, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132C6 */) {} // 0x000000018281ECE0-0x000000018281F120
	// [IDTag] // 0x00000001898928D0-0x0000000189892910
	// [XID] // 0x00000001898928D0-0x0000000189892910
	public Sprite LoadSprite(string name, string subPath) => default; // 0x00000001828215E0-0x00000001828217C0
	// [IDTag] // 0x000000018989CD60-0x000000018989CDA0
	// [XID] // 0x000000018989CD60-0x000000018989CDA0
	public AsyncJob LoadSpriteAsync(string name, string subPath, Action<Sprite> onResult) => default; // 0x000000018281F120-0x000000018281F380
	// [IDTag] // 0x00000001898A73A0-0x00000001898A73E0
	// [XID] // 0x00000001898A73A0-0x00000001898A73E0
	public void LoadSpriteAsync(string name, string subPath, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132C7 */) {} // 0x000000018281EAC0-0x000000018281ECE0
	// [XID] // 0x00000001898B1B50-0x00000001898B1B70
	public Sprite GetPropertyIconSprite(string iconName) => default; // 0x000000018281BCA0-0x000000018281BD60
	// [IDTag] // 0x00000001898B9770-0x00000001898B97B0
	// [XID] // 0x00000001898B9770-0x00000001898B97B0
	public Sprite GetMonsterItemSprite(string iconName, bool smallIcon = false /* Metadata: 0x00B132C8 */) => default; // 0x0000000182818110-0x0000000182818230
	// [XID] // 0x00000001898C3B60-0x00000001898C3B80
	public Sprite GetActivityBgSprite(string iconName) => default; // 0x0000000182817D00-0x0000000182817DC0
	// [XID] // 0x00000001898CB3E0-0x00000001898CB400
	public Sprite GetLoadingBgSprite(string iconName) => default; // 0x000000018281A090-0x000000018281A150
	// [XID] // 0x00000001898D2AA0-0x00000001898D2AC0
	public Sprite GetFriendTabIconSprite(string iconName) => default; // 0x000000018281E740-0x000000018281E800
	// [XID] // 0x00000001898DA460-0x00000001898DA480
	public Sprite GetInvestigationImage(string imgName) => default; // 0x00000001828202B0-0x0000000182820370
	// [XID] // 0x00000001898E2130-0x00000001898E2150
	public Sprite GetMessagePushIcon(string iconName) => default; // 0x000000018281A150-0x000000018281A210
	// [XID] // 0x00000001898E9D10-0x00000001898E9D30
	public Sprite GetTowerFloorItemImage(string imgName) => default; // 0x00000001828212C0-0x0000000182821380
	// [XID] // 0x00000001898F1430-0x00000001898F1450
	public Sprite GetSystemOpenUIIconSprite(string iconName) => default; // 0x000000018281D100-0x000000018281D1C0
	// [XID] // 0x00000001898F8BE0-0x00000001898F8C00
	public Sprite GetDungeonEntryImage(string imgName) => default; // 0x00000001828198F0-0x00000001828199B0
	// [XID] // 0x0000000189900530-0x0000000189900550
	public Sprite GetBattlePassPreviewImage(string imgName) => default; // 0x000000018281DBA0-0x000000018281DC60
	// [XID] // 0x0000000189907C70-0x0000000189907C90
	public Sprite GetElementIcon(string iconName) => default; // 0x000000018281C0E0-0x000000018281C1A0
	// [XID] // 0x000000018990F460-0x000000018990F480
	public Sprite GetNameCardPic(string iconName) => default; // 0x0000000182816BD0-0x0000000182816C90
	// [XID] // 0x0000000189916EF0-0x0000000189916F10
	public Sprite GetGachaSlotImg(string imgName) => default; // 0x000000018281B320-0x000000018281B3E0
	// [XID] // 0x000000018991E650-0x000000018991E670
	public Sprite GetNetStateImg(string imgName) => default; // 0x00000001828196E0-0x00000001828197A0
	// [XID] // 0x0000000189925E50-0x0000000189925E70
	public Sprite GetAchievementIcon(string imgName) => default; // 0x000000018281A210-0x000000018281A2D0
	// [XID] // 0x000000018992D3E0-0x000000018992D400
	public Sprite GetAchievementSmallIcon(string imgName) => default; // 0x000000018281C020-0x000000018281C0E0
	// [IDTag] // 0x0000000189934910-0x0000000189934950
	// [XID] // 0x0000000189934910-0x0000000189934950
	public Sprite GetItemSprite(string iconName) => default; // 0x0000000182820600-0x00000001828206C0
	// [IDTag] // 0x000000018993F230-0x000000018993F270
	// [XID] // 0x000000018993F230-0x000000018993F270
	public Sprite GetItemSprite(ItemConfig itemConfig) => default; // 0x0000000182820370-0x0000000182820600
	// [IDTag] // 0x0000000189949850-0x0000000189949890
	// [XID] // 0x0000000189949850-0x0000000189949890
	public Sprite GetMonsterItemSprite(string iconName) => default; // 0x0000000182818230-0x00000001828182F0
	// [XID] // 0x0000000189953E60-0x0000000189953E80
	public Sprite GetItemImageSprite(string iconImageName) => default; // 0x0000000182817DC0-0x0000000182817F10
	// [XID] // 0x000000018995B660-0x000000018995B680
	public Sprite GetAvatarSprite(string iconName) => default; // 0x000000018281CA60-0x000000018281CB20
	// [XID] // 0x0000000189963240-0x0000000189963260
	public Sprite GetSkillIcon(string iconName) => default; // 0x0000000182820FF0-0x00000001828210B0
	// [XID] // 0x000000018996A600-0x000000018996A620
	public Sprite GetGachaIcon(string iconName) => default; // 0x0000000182820C50-0x0000000182820D10
	// [XID] // 0x00000001899722C0-0x00000001899722E0
	public Sprite GetElementBuffIcon(string iconName) => default; // 0x00000001828201F0-0x00000001828202B0
	// [XID] // 0x0000000189979AE0-0x0000000189979B00
	public Sprite GetMapMarkIcon(string iconName) => default; // 0x0000000182816910-0x00000001828169D0
	// [XID] // 0x0000000189981310-0x0000000189981330
	public Sprite GetItemtipsBgSprite(QualityType qualityType) => default; // 0x000000018281A4D0-0x000000018281A5F0
	// [XID] // 0x0000000189988AE0-0x0000000189988B00
	public Sprite GetPendantIconSprite(ElementType elemType) => default; // 0x0000000182818C90-0x0000000182818E20
	// [XID] // 0x0000000189990280-0x00000001899902A0
	public Sprite GetInteeIconSprite(string iconName) => default; // 0x000000018281CEA0-0x000000018281CF60
	// [XID] // 0x0000000189997DB0-0x0000000189997DD0
	public Sprite GetBagTabIconSprite(string iconName) => default; // 0x00000001828187C0-0x0000000182818880
	// [XID] // 0x000000018999F540-0x000000018999F560
	public Sprite GetQuestTabIconSprite(string iconName) => default; // 0x0000000182816E90-0x0000000182816F50
	// [XID] // 0x00000001899A7070-0x00000001899A7090
	public Sprite GetReadPicSprite(string iconName) => default; // 0x000000018281BBE0-0x000000018281BCA0
	// [XID] // 0x00000001899AE9A0-0x00000001899AE9C0
	public Sprite GetTutorialImageSprite(string imgName) => default; // 0x000000018281C9A0-0x000000018281CA60
	// [XID] // 0x00000001899B5D20-0x00000001899B5D40
	public Sprite GetTalentIconSprite(string imgName) => default; // 0x0000000182818FF0-0x00000001828190B0
	// [XID] // 0x00000001899BDA60-0x00000001899BDA80
	public Sprite GetInputKeyIconSprite(string imgName) => default; // 0x000000018281CB20-0x000000018281CBE0
	// [XID] // 0x00000001899C5160-0x00000001899C5180
	public Sprite GetGoddessUnlockIcon(string iconName) => default; // 0x0000000182818880-0x0000000182818940
	// [XID] // 0x00000001899CC850-0x00000001899CC870
	public Sprite GetNpcTopIcon(string iconName) => default; // 0x000000018281A7F0-0x000000018281A8B0
	// [XID] // 0x00000001899D3F20-0x00000001899D3F40
	public Sprite GetPlayerIcon(bool isMale) => default; // 0x000000018281E670-0x000000018281E740
	// [XID] // 0x00000001899DB490-0x00000001899DB4B0
	public Sprite GetButtonIcon(string iconName) => default; // 0x0000000182816250-0x0000000182816310
	// [XID] // 0x00000001899E2B90-0x00000001899E2BB0
	public Sprite GetDungeonTypeSprite(string iconName) => default; // 0x000000018281DE60-0x000000018281DF20
	// [XID] // 0x00000001899EA250-0x00000001899EA270
	public Sprite GetDungeonTypeSpriteByDungeonType(DungeonType dungeonType) => default; // 0x000000018281CF60-0x000000018281D040
	// [XID] // 0x00000001899F1CA0-0x00000001899F1CC0
	public Sprite GetEventIcon(string iconName) => default; // 0x000000018281CBE0-0x000000018281CCA0
	// [XID] // 0x00000001899F94C0-0x00000001899F94E0
	public Sprite GetChapterIconSprite(string iconName) => default; // 0x000000018281D7C0-0x000000018281D880
	// [XID] // 0x0000000189A007A0-0x0000000189A007C0
	public Sprite GetTerrainSprite(string iconName) => default; // 0x00000001828197A0-0x00000001828198F0
	// [XID] // 0x0000000189A080E0-0x0000000189A08100
	public Sprite GetExploreBgSprite(string iconName) => default; // 0x000000018281BD60-0x000000018281BE20
	// [XID] // 0x0000000189A0F480-0x0000000189A0F4A0
	public Sprite GetSmallItemIconSprite(string iconName) => default; // 0x0000000182819390-0x00000001828194E0
	// [XID] // 0x0000000189A16B80-0x0000000189A16BA0
	public Sprite GetHomeworldTabIconSprite(string iconName) => default; // 0x000000018281B260-0x000000018281B320
	// [XID] // 0x0000000189A1E1A0-0x0000000189A1E1C0
	public Sprite GetHomeworldItemIconSprite(string iconName) => default; // 0x000000018281D040-0x000000018281D100
	// [XID] // 0x0000000189A258E0-0x0000000189A25900
	public Sprite GetHomeworldSuiteItemIconSprite(string iconName) => default; // 0x000000018281EA00-0x000000018281EAC0
	// [XID] // 0x0000000189A2CCE0-0x0000000189A2CD00
	public Sprite GetHomeworldAnimalItemIconSprite(string iconName) => default; // 0x0000000182818F30-0x0000000182818FF0
	// [XID] // 0x0000000189A34670-0x0000000189A34690
	public Sprite GetHomeworldModuleSprite(string spriteName) => default; // 0x000000018281C8E0-0x000000018281C9A0
	// [XID] // 0x0000000189A3BAF0-0x0000000189A3BB10
	public Sprite GetHomeworldModulePicSprite(string picName) => default; // 0x0000000182819D00-0x0000000182819DC0
	// [IDTag] // 0x0000000189A43720-0x0000000189A43760
	// [XID] // 0x0000000189A43720-0x0000000189A43760
	public AsyncJob GetPropertyIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281E550-0x000000018281E670
	// [IDTag] // 0x0000000189A4DCC0-0x0000000189A4DD00
	// [XID] // 0x0000000189A4DCC0-0x0000000189A4DD00
	public AsyncJob GetMonsterItemSpriteAsync(string iconName, Action<Sprite> onResult, bool smallIcon = false /* Metadata: 0x00B132C9 */) => default; // 0x0000000182818660-0x00000001828187C0
	// [IDTag] // 0x0000000189A58220-0x0000000189A58260
	// [XID] // 0x0000000189A58220-0x0000000189A58260
	public AsyncJob GetActivityBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281A3B0-0x000000018281A4D0
	// [IDTag] // 0x0000000189A62C10-0x0000000189A62C50
	// [XID] // 0x0000000189A62C10-0x0000000189A62C50
	public AsyncJob GetLoadingBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828195C0-0x00000001828196E0
	// [IDTag] // 0x0000000189A6D4A0-0x0000000189A6D4E0
	// [XID] // 0x0000000189A6D4A0-0x0000000189A6D4E0
	public AsyncJob GetFriendTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182816510-0x0000000182816630
	// [IDTag] // 0x0000000189A77EF0-0x0000000189A77F30
	// [XID] // 0x0000000189A77EF0-0x0000000189A77F30
	public AsyncJob GetInvestigationImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281B7E0-0x000000018281B900
	// [IDTag] // 0x0000000189A827F0-0x0000000189A82830
	// [XID] // 0x0000000189A827F0-0x0000000189A82830
	public AsyncJob GetMessagePushIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281A6D0-0x000000018281A7F0
	// [IDTag] // 0x0000000189A8D130-0x0000000189A8D170
	// [XID] // 0x0000000189A8D130-0x0000000189A8D170
	public AsyncJob GetTowerFloorItemImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182817440-0x0000000182817560
	// [IDTag] // 0x0000000189A97980-0x0000000189A979C0
	// [XID] // 0x0000000189A97980-0x0000000189A979C0
	public AsyncJob GetSystemOpenUIIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828190B0-0x00000001828191D0
	// [IDTag] // 0x0000000189AA1E10-0x0000000189AA1E50
	// [XID] // 0x0000000189AA1E10-0x0000000189AA1E50
	public AsyncJob GetDungeonEntryImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281E8E0-0x000000018281EA00
	// [IDTag] // 0x0000000189AAC5E0-0x0000000189AAC620
	// [XID] // 0x0000000189AAC5E0-0x0000000189AAC620
	public AsyncJob GetBattlePassPreviewImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828200D0-0x00000001828201F0
	// [IDTag] // 0x0000000189AB6E90-0x0000000189AB6ED0
	// [XID] // 0x0000000189AB6E90-0x0000000189AB6ED0
	public AsyncJob GetElementIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281CCA0-0x000000018281CDC0
	// [IDTag] // 0x0000000189AC1A10-0x0000000189AC1A50
	// [XID] // 0x0000000189AC1A10-0x0000000189AC1A50
	public AsyncJob GetNameCardPicAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828210B0-0x00000001828211D0
	// [IDTag] // 0x0000000189ACC160-0x0000000189ACC1A0
	// [XID] // 0x0000000189ACC160-0x0000000189ACC1A0
	public AsyncJob GetGachaSlotImgAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182817F10-0x0000000182818030
	// [IDTag] // 0x0000000189AD6F90-0x0000000189AD6FD0
	// [XID] // 0x0000000189AD6F90-0x0000000189AD6FD0
	public AsyncJob GetNetStateImgAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828169D0-0x0000000182816AF0
	// [IDTag] // 0x0000000189AE1870-0x0000000189AE18B0
	// [XID] // 0x0000000189AE1870-0x0000000189AE18B0
	public AsyncJob GetAchievementIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281BF00-0x000000018281C020
	// [IDTag] // 0x0000000189AEC190-0x0000000189AEC1D0
	// [XID] // 0x0000000189AEC190-0x0000000189AEC1D0
	public AsyncJob GetAchievementSmallIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828163F0-0x0000000182816510
	// [IDTag] // 0x0000000189AF69B0-0x0000000189AF69F0
	// [XID] // 0x0000000189AF69B0-0x0000000189AF69F0
	public AsyncJob GetItemSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182817BE0-0x0000000182817D00
	// [IDTag] // 0x0000000189B010F0-0x0000000189B01130
	// [XID] // 0x0000000189B010F0-0x0000000189B01130
	public AsyncJob GetItemSpriteAsync(ItemConfig itemConfig, Action<Sprite> onResult) => default; // 0x0000000182817650-0x0000000182817930
	// [IDTag] // 0x0000000189B0B830-0x0000000189B0B870
	// [XID] // 0x0000000189B0B830-0x0000000189B0B870
	public AsyncJob GetMonsterItemSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182818540-0x0000000182818660
	// [IDTag] // 0x0000000189B15B30-0x0000000189B15B70
	// [XID] // 0x0000000189B15B30-0x0000000189B15B70
	public AsyncJob GetItemImageSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828199B0-0x0000000182819B70
	// [IDTag] // 0x0000000189B202D0-0x0000000189B20310
	// [XID] // 0x0000000189B202D0-0x0000000189B20310
	public AsyncJob GetAvatarSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281AE40-0x000000018281AF60
	// [IDTag] // 0x0000000189B2A7B0-0x0000000189B2A7F0
	// [XID] // 0x0000000189B2A7B0-0x0000000189B2A7F0
	public AsyncJob GetSkillIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182820A50-0x0000000182820B70
	// [IDTag] // 0x0000000189B34AA0-0x0000000189B34AE0
	// [XID] // 0x0000000189B34AA0-0x0000000189B34AE0
	public AsyncJob GetGachaIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182820ED0-0x0000000182820FF0
	// [IDTag] // 0x0000000189B3F6A0-0x0000000189B3F6E0
	// [XID] // 0x0000000189B3F6A0-0x0000000189B3F6E0
	public AsyncJob GetElementBuffIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182817150-0x0000000182817270
	// [IDTag] // 0x0000000189B4A090-0x0000000189B4A0D0
	// [XID] // 0x0000000189B4A090-0x0000000189B4A0D0
	public AsyncJob GetMapMarkIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281F7F0-0x000000018281F910
	// [IDTag] // 0x0000000189B54530-0x0000000189B54570
	// [XID] // 0x0000000189B54530-0x0000000189B54570
	public AsyncJob GetItemtipsBgSpriteAsync(QualityType qualityType, Action<Sprite> onResult) => default; // 0x00000001828218F0-0x0000000182821A60
	// [IDTag] // 0x0000000189B5F030-0x0000000189B5F070
	// [XID] // 0x0000000189B5F030-0x0000000189B5F070
	public AsyncJob GetPendantIconSpriteAsync(ElementType elemType, Action<Sprite> onResult) => default; // 0x000000018281A8B0-0x000000018281AA90
	// [IDTag] // 0x0000000189B697C0-0x0000000189B69800
	// [XID] // 0x0000000189B697C0-0x0000000189B69800
	public AsyncJob GetInteeIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281DD40-0x000000018281DE60
	// [IDTag] // 0x0000000189B73B50-0x0000000189B73B90
	// [XID] // 0x0000000189B73B50-0x0000000189B73B90
	public AsyncJob GetBagTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281E000-0x000000018281E120
	// [IDTag] // 0x0000000189B7E000-0x0000000189B7E040
	// [XID] // 0x0000000189B7E000-0x0000000189B7E040
	public AsyncJob GetQuestTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281B5E0-0x000000018281B700
	// [IDTag] // 0x0000000189B88970-0x0000000189B889B0
	// [XID] // 0x0000000189B88970-0x0000000189B889B0
	public AsyncJob GetReadPicSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281FBF0-0x000000018281FD10
	// [IDTag] // 0x0000000189B92AC0-0x0000000189B92B00
	// [XID] // 0x0000000189B92AC0-0x0000000189B92B00
	public AsyncJob GetTutorialImageSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281F9F0-0x000000018281FB10
	// [IDTag] // 0x0000000189B9CE90-0x0000000189B9CED0
	// [XID] // 0x0000000189B9CE90-0x0000000189B9CED0
	public AsyncJob GetTalentIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281FED0-0x000000018281FFF0
	// [IDTag] // 0x0000000189BA7780-0x0000000189BA77C0
	// [XID] // 0x0000000189BA7780-0x0000000189BA77C0
	public AsyncJob GetInputKeyIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281D2A0-0x000000018281D3C0
	// [IDTag] // 0x0000000189BB1C50-0x0000000189BB1C90
	// [XID] // 0x0000000189BB1C50-0x0000000189BB1C90
	public AsyncJob GetGoddessUnlockIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001828167F0-0x0000000182816910
	// [IDTag] // 0x0000000189BBC080-0x0000000189BBC0C0
	// [XID] // 0x0000000189BBC080-0x0000000189BBC0C0
	public AsyncJob GetNpcTopIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281BAC0-0x000000018281BBE0
	// [IDTag] // 0x0000000189BC6A30-0x0000000189BC6A70
	// [XID] // 0x0000000189BC6A30-0x0000000189BC6A70
	public AsyncJob GetPlayerIconAsync(bool isMale, Action<Sprite> onResult) => default; // 0x000000018281B130-0x000000018281B260
	// [IDTag] // 0x0000000189BD15A0-0x0000000189BD15E0
	// [XID] // 0x0000000189BD15A0-0x0000000189BD15E0
	public AsyncJob GetButtonIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182820850-0x0000000182820970
	// [IDTag] // 0x0000000189BDC050-0x0000000189BDC090
	// [XID] // 0x0000000189BDC050-0x0000000189BDC090
	public AsyncJob GetDungeonTypeSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182816D70-0x0000000182816E90
	// [IDTag] // 0x00000001895EBAA0-0x00000001895EBAE0
	// [XID] // 0x00000001895EBAA0-0x00000001895EBAE0
	public AsyncJob GetDungeonTypeSpriteByDungeonTypeAsync(DungeonType dungeonType, Action<Sprite> onResult) => default; // 0x000000018281D970-0x000000018281DAA0
	// [IDTag] // 0x00000001895F6180-0x00000001895F61C0
	// [XID] // 0x00000001895F6180-0x00000001895F61C0
	public AsyncJob GetEventIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281C600-0x000000018281C720
	// [IDTag] // 0x00000001896006C0-0x0000000189600700
	// [XID] // 0x00000001896006C0-0x0000000189600700
	public AsyncJob GetChapterIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182819DC0-0x0000000182819EE0
	// [IDTag] // 0x000000018960B2C0-0x000000018960B300
	// [XID] // 0x000000018960B2C0-0x000000018960B300
	public AsyncJob GetTerrainSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281E2B0-0x000000018281E470
	// [IDTag] // 0x00000001896156A0-0x00000001896156E0
	// [XID] // 0x00000001896156A0-0x00000001896156E0
	public AsyncJob GetExploreBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182817030-0x0000000182817150
	// [IDTag] // 0x000000018961FF80-0x000000018961FFC0
	// [XID] // 0x000000018961FF80-0x000000018961FFC0
	public AsyncJob GetSmallItemIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000182818AD0-0x0000000182818C90
	// [XID] // 0x000000018962A4B0-0x000000018962A4D0
	public AsyncJob GetActivityBuffSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281F5E0-0x000000018281F700
	// [XID] // 0x0000000189631C30-0x0000000189631C50
	public AsyncJob GetHomeworldTabIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281C2E0-0x000000018281C400
	// [XID] // 0x00000001896397A0-0x00000001896397C0
	public AsyncJob GetHomeworldItemIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018281B3E0-0x000000018281B500
	// [XID] // 0x0000000189640C80-0x0000000189640CA0
	public AsyncJob GetHomeworldModuleSpriteAsync(string spriteNmae, Action<Sprite> onResult) => default; // 0x000000018281AC40-0x000000018281AD60
	// [XID] // 0x00000001896485D0-0x00000001896485F0
	public AsyncJob GetHomeworldModulePicAsync(string picName, Action<Sprite> onResult) => default; // 0x000000018281C400-0x000000018281C520
	// [IDTag] // 0x000000018964FC60-0x000000018964FCA0
	// [XID] // 0x000000018964FC60-0x000000018964FCA0
	public void GetPropertyIconSpriteAsync(string iconName, Image image) {} // 0x000000018281E470-0x000000018281E550
	// [IDTag] // 0x000000018965A3E0-0x000000018965A420
	// [XID] // 0x000000018965A3E0-0x000000018965A420
	public void GetMonsterItemSpriteAsync(string iconName, Image image, bool smallIcon = false /* Metadata: 0x00B132CA */) {} // 0x00000001828183D0-0x0000000182818540
	// [XID] // 0x0000000189664C40-0x0000000189664C60
	public void GetBlossomItemSpriteAsync(string iconName, Image image, bool smallIcon = false /* Metadata: 0x00B132CB */) {} // 0x000000018281C1A0-0x000000018281C2E0
	// [IDTag] // 0x000000018966C1D0-0x000000018966C210
	// [XID] // 0x000000018966C1D0-0x000000018966C210
	public void GetActivityBgSpriteAsync(string iconName, Image image) {} // 0x000000018281A2D0-0x000000018281A3B0
	// [IDTag] // 0x0000000189677040-0x0000000189677080
	// [XID] // 0x0000000189677040-0x0000000189677080
	public void GetLoadingBgSpriteAsync(string iconName, Image image) {} // 0x00000001828194E0-0x00000001828195C0
	// [IDTag] // 0x00000001896818C0-0x0000000189681900
	// [XID] // 0x00000001896818C0-0x0000000189681900
	public void GetFriendTabIconSpriteAsync(string iconName, Image image) {} // 0x0000000182816630-0x0000000182816710
	// [IDTag] // 0x000000018968C310-0x000000018968C350
	// [XID] // 0x000000018968C310-0x000000018968C350
	public void GetInvestigationImageAsync(string iconName, Image image) {} // 0x000000018281B700-0x000000018281B7E0
	// [IDTag] // 0x0000000189697030-0x0000000189697070
	// [XID] // 0x0000000189697030-0x0000000189697070
	public void GetMessagePushIconAsync(string iconName, Image image) {} // 0x000000018281A5F0-0x000000018281A6D0
	// [IDTag] // 0x00000001896A1230-0x00000001896A1270
	// [XID] // 0x00000001896A1230-0x00000001896A1270
	public void GetTowerFloorItemImageAsync(string iconName, Image image) {} // 0x0000000182817360-0x0000000182817440
	// [IDTag] // 0x00000001896AB560-0x00000001896AB5A0
	// [XID] // 0x00000001896AB560-0x00000001896AB5A0
	public void GetSystemOpenUIIconSpriteAsync(string iconName, Image image) {} // 0x00000001828191D0-0x00000001828192B0
	// [IDTag] // 0x00000001896B5C50-0x00000001896B5C90
	// [XID] // 0x00000001896B5C50-0x00000001896B5C90
	public void GetDungeonEntryImageAsync(string iconName, Image image) {} // 0x000000018281E800-0x000000018281E8E0
	// [IDTag] // 0x00000001896BFB80-0x00000001896BFBC0
	// [XID] // 0x00000001896BFB80-0x00000001896BFBC0
	public void GetBattlePassPreviewImageAsync(string iconName, Image image) {} // 0x000000018281FFF0-0x00000001828200D0
	// [IDTag] // 0x00000001896CA0E0-0x00000001896CA120
	// [XID] // 0x00000001896CA0E0-0x00000001896CA120
	public void GetElementIconAsync(string iconName, Image image) {} // 0x000000018281CDC0-0x000000018281CEA0
	// [IDTag] // 0x00000001896D4730-0x00000001896D4770
	// [XID] // 0x00000001896D4730-0x00000001896D4770
	public void GetNameCardPicAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132CC */) {} // 0x00000001828211D0-0x00000001828212C0
	// [IDTag] // 0x00000001896DEF60-0x00000001896DEFA0
	// [XID] // 0x00000001896DEF60-0x00000001896DEFA0
	public void GetGachaSlotImgAsync(string iconName, Image image) {} // 0x0000000182818030-0x0000000182818110
	// [IDTag] // 0x00000001896E9480-0x00000001896E94C0
	// [XID] // 0x00000001896E9480-0x00000001896E94C0
	public void GetNetStateImgAsync(string iconName, Image image) {} // 0x0000000182816AF0-0x0000000182816BD0
	// [IDTag] // 0x00000001896F3950-0x00000001896F3990
	// [XID] // 0x00000001896F3950-0x00000001896F3990
	public void GetAchievementIconAsync(string iconName, Image image) {} // 0x000000018281BE20-0x000000018281BF00
	// [IDTag] // 0x00000001896FE3B0-0x00000001896FE3F0
	// [XID] // 0x00000001896FE3B0-0x00000001896FE3F0
	public void GetAchievementSmallIconAsync(string iconName, Image image) {} // 0x0000000182816310-0x00000001828163F0
	// [IDTag] // 0x0000000189708640-0x0000000189708680
	// [XID] // 0x0000000189708640-0x0000000189708680
	public void GetItemSpriteAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132CD */) {} // 0x0000000182817560-0x0000000182817650
	// [IDTag] // 0x0000000189712ED0-0x0000000189712F10
	// [XID] // 0x0000000189712ED0-0x0000000189712F10
	public void GetItemSpriteAsync(ItemConfig itemConfig, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132CE */) {} // 0x0000000182817930-0x0000000182817BE0
	// [XID] // 0x000000018971D600-0x000000018971D620
	public void GetHomeWorldIconAsync(string iconName, Image image) {} // 0x000000018281AF60-0x000000018281B040
	// [IDTag] // 0x0000000189724940-0x0000000189724980
	// [XID] // 0x0000000189724940-0x0000000189724980
	public void GetMonsterItemSpriteAsync(string iconName, Image image) {} // 0x00000001828182F0-0x00000001828183D0
	// [XID] // 0x000000018972F1D0-0x000000018972F1F0
	public void GetAnimalItemSpriteAsync(string iconName, Image image) {} // 0x00000001828192B0-0x0000000182819390
	// [IDTag] // 0x0000000189736BE0-0x0000000189736C20
	// [XID] // 0x0000000189736BE0-0x0000000189736C20
	public void GetItemImageSpriteAsync(string iconName, Image image) {} // 0x0000000182819B70-0x0000000182819D00
	// [XID] // 0x0000000189741440-0x0000000189741460
	public void GetRomanNumImageSpriteAsync(string iconName, Image image) {} // 0x00000001828206C0-0x0000000182820850
	// [IDTag] // 0x0000000189748D80-0x0000000189748DC0
	// [XID] // 0x0000000189748D80-0x0000000189748DC0
	public void GetAvatarSpriteAsync(string iconName, Image image) {} // 0x000000018281AD60-0x000000018281AE40
	// [IDTag] // 0x00000001897530B0-0x00000001897530F0
	// [XID] // 0x00000001897530B0-0x00000001897530F0
	public void GetSkillIconAsync(string iconName, Image image) {} // 0x0000000182820B70-0x0000000182820C50
	// [IDTag] // 0x000000018975D620-0x000000018975D660
	// [XID] // 0x000000018975D620-0x000000018975D660
	public void GetGachaIconAsync(string iconName, Image image) {} // 0x0000000182820DF0-0x0000000182820ED0
	// [IDTag] // 0x0000000189767C80-0x0000000189767CC0
	// [XID] // 0x0000000189767C80-0x0000000189767CC0
	public void GetElementBuffIconAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132CF */) {} // 0x0000000182817270-0x0000000182817360
	// [IDTag] // 0x0000000189772580-0x00000001897725C0
	// [XID] // 0x0000000189772580-0x00000001897725C0
	public void GetMapMarkIconAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132D0 */) {} // 0x000000018281F700-0x000000018281F7F0
	// [IDTag] // 0x000000018977CBD0-0x000000018977CC10
	// [XID] // 0x000000018977CBD0-0x000000018977CC10
	public void GetItemtipsBgSpriteAsync(QualityType qualityType, Image image) {} // 0x00000001828217C0-0x00000001828218F0
	// [IDTag] // 0x0000000189787470-0x00000001897874B0
	// [XID] // 0x0000000189787470-0x00000001897874B0
	public void GetPendantIconSpriteAsync(ElementType elemType, Image image) {} // 0x000000018281AA90-0x000000018281AC40
	// [IDTag] // 0x0000000189791AD0-0x0000000189791B10
	// [XID] // 0x0000000189791AD0-0x0000000189791B10
	public void GetInteeIconSpriteAsync(string iconName, Image image) {} // 0x000000018281DC60-0x000000018281DD40
	// [IDTag] // 0x000000018979C960-0x000000018979C9A0
	// [XID] // 0x000000018979C960-0x000000018979C9A0
	public void GetBagTabIconSpriteAsync(string iconName, Image image) {} // 0x000000018281DF20-0x000000018281E000
	// [IDTag] // 0x00000001897A6DD0-0x00000001897A6E10
	// [XID] // 0x00000001897A6DD0-0x00000001897A6E10
	public void GetQuestTabIconSpriteAsync(string iconName, Image image) {} // 0x000000018281B500-0x000000018281B5E0
	// [IDTag] // 0x00000001897B1710-0x00000001897B1750
	// [XID] // 0x00000001897B1710-0x00000001897B1750
	public void GetReadPicSpriteAsync(string iconName, Image image) {} // 0x000000018281FB10-0x000000018281FBF0
	// [IDTag] // 0x00000001897BCC60-0x00000001897BCCA0
	// [XID] // 0x00000001897BCC60-0x00000001897BCCA0
	public void GetTutorialImageSpriteAsync(string iconName, Image image) {} // 0x000000018281F910-0x000000018281F9F0
	// [XID] // 0x00000001897C75B0-0x00000001897C75D0
	public void GetCodexViewImageSpriteAsync(string iconName, Image image) {} // 0x000000018281C720-0x000000018281C800
	// [XID] // 0x00000001897CE8C0-0x00000001897CE8E0
	public void GetCodexViewPicSpriteAsync(string iconName, Image image) {} // 0x0000000182821380-0x0000000182821460
	// [IDTag] // 0x00000001897D6080-0x00000001897D60C0
	// [XID] // 0x00000001897D6080-0x00000001897D60C0
	public void GetTalentIconSpriteAsync(string iconName, Image image) {} // 0x000000018281FDF0-0x000000018281FED0
	// [IDTag] // 0x00000001897E0910-0x00000001897E0950
	// [XID] // 0x00000001897E0910-0x00000001897E0950
	public void GetInputKeyIconSpriteAsync(string iconName, Image image) {} // 0x000000018281D1C0-0x000000018281D2A0
	// [IDTag] // 0x00000001897EB600-0x00000001897EB640
	// [XID] // 0x00000001897EB600-0x00000001897EB640
	public void GetGoddessUnlockIconAsync(string iconName, Image image) {} // 0x0000000182816710-0x00000001828167F0
	// [IDTag] // 0x00000001897F5C50-0x00000001897F5C90
	// [XID] // 0x00000001897F5C50-0x00000001897F5C90
	public void GetNpcTopIconAsync(string iconName, Image image) {} // 0x000000018281B9E0-0x000000018281BAC0
	// [IDTag] // 0x00000001898003F0-0x0000000189800430
	// [XID] // 0x00000001898003F0-0x0000000189800430
	public void GetPlayerIconAsync(bool isMale, Image image) {} // 0x000000018281B040-0x000000018281B130
	// [IDTag] // 0x000000018980AA60-0x000000018980AAA0
	// [XID] // 0x000000018980AA60-0x000000018980AAA0
	public void GetButtonIconAsync(string iconName, Image image) {} // 0x0000000182820970-0x0000000182820A50
	// [IDTag] // 0x0000000189815020-0x0000000189815060
	// [XID] // 0x0000000189815020-0x0000000189815060
	public void GetDungeonTypeSpriteAsync(string iconName, Image image) {} // 0x0000000182816C90-0x0000000182816D70
	// [IDTag] // 0x000000018981FC90-0x000000018981FCD0
	// [XID] // 0x000000018981FC90-0x000000018981FCD0
	public void GetDungeonTypeSpriteByDungeonTypeAsync(DungeonType dungeonType, Image image) {} // 0x000000018281DAA0-0x000000018281DBA0
	// [IDTag] // 0x000000018982A270-0x000000018982A2B0
	// [XID] // 0x000000018982A270-0x000000018982A2B0
	public void GetEventIconAsync(string iconName, Image image) {} // 0x000000018281C520-0x000000018281C600
	// [IDTag] // 0x00000001898346A0-0x00000001898346E0
	// [XID] // 0x00000001898346A0-0x00000001898346E0
	public void GetChapterIconSpriteAsync(string iconName, Image image) {} // 0x0000000182819EE0-0x0000000182819FC0
	// [IDTag] // 0x000000018983EC70-0x000000018983ECB0
	// [XID] // 0x000000018983EC70-0x000000018983ECB0
	public void GetTerrainSpriteAsync(string iconName, Image image) {} // 0x000000018281E120-0x000000018281E2B0
	// [IDTag] // 0x0000000189848EB0-0x0000000189848EF0
	// [XID] // 0x0000000189848EB0-0x0000000189848EF0
	public void GetExploreBgSpriteAsync(string iconName, Image image) {} // 0x0000000182816F50-0x0000000182817030
	// [IDTag] // 0x0000000189853190-0x00000001898531D0
	// [XID] // 0x0000000189853190-0x00000001898531D0
	public void GetSmallItemIconSpriteAsync(string iconName, Image image) {} // 0x0000000182818940-0x0000000182818AD0
	// [XID] // 0x000000018985D4B0-0x000000018985D4D0
	public void GetActivityBuffIconSpriteAsync(string iconName, Image image) {} // 0x000000018281C800-0x000000018281C8E0
	// [XID] // 0x0000000189864E90-0x0000000189864EB0
	public void GetReputationPicSpriteAsync(string iconName, Image image) {} // 0x000000018281D6E0-0x000000018281D7C0
	// [XID] // 0x000000018986C4B0-0x000000018986C4D0
	public void GetReputationBgSpriteAsync(string iconName, Image image) {} // 0x000000018281B900-0x000000018281B9E0
	// [XID] // 0x0000000189873830-0x0000000189873850
	public void GetNpcIconSpriteAsync(string iconName, Image image) {} // 0x0000000182820D10-0x0000000182820DF0
	// [XID] // 0x000000018987B370-0x000000018987B390
	public void GetMechanicusMapSprite(string iconName, Image image, bool smallIcon = false /* Metadata: 0x00B132D1 */) {} // 0x0000000182818E20-0x0000000182818F30
	// [XID] // 0x0000000189882530-0x0000000189882550
	public void GetMechanicusCardIconSpriteAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B132D2 */) {} // 0x000000018281D880-0x000000018281D970
}

