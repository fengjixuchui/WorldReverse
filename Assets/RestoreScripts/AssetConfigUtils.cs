/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AssetConfigUtils // TypeDefIndex: 31369
{
    // Fields
    private const string AVATAR_ASSOC_INFO_ASSET_PATH = "Data/UI/DefaultAvatarAssociationInfo"; // Metadata: 0x00B12316
    private static AvatarAssociationInfo _avatarAssocInfo; // 0x00
    private const string ELEMENT_STYLE_ASSET_PATH = "Data/UI/DefaultElementStyle"; // Metadata: 0x00B1233E
    private static ElementStyle _elementStyle; // 0x08
    private const string ELEMENT_REACTION_STYLE_ASSET_PATH = "Data/UI/DefaultElementReactionStyle"; // Metadata: 0x00B1235D
    private static ElementReactionStyle _elementReactionStyle; // 0x10
    private const string AVATAR_ELEMENT_STYLE_ASSET_PATH = "Data/UI/AvatarElementStyle"; // Metadata: 0x00B12384
    private static AvatarElementStyle _avatarElementStyle; // 0x18
    private const string EQUIP_ELEMENT_STYLE_ASSET_PATH = "Data/UI/EquipElementStyle"; // Metadata: 0x00B123A2
    private static EquipElementStyle _equipElementStyle; // 0x20
    private const string PROPERTY_FORMAT_STYLE_PATH = "Data/UI/DefaultPropertyFormatStyle"; // Metadata: 0x00B123BF
    private static PropertyFormatStyle _propertyFormatStyle; // 0x28
    private const string CHARACTERVIEW_STYLE_ASSET_PATH = "Data/UI/DefaultCharacterViewStyle"; // Metadata: 0x00B123E5
    private static CharacterViewStyle _characterStyle; // 0x30
    private const string BODY_CAMERA_STYLE_ASSET_PATH = "Data/UI/DefaultBodyCameraStyle"; // Metadata: 0x00B1240A
    private static BodyCameraStyle _bodyCameraStyle; // 0x38
    private const string PALETTE_PATH = "Data/UI/DefaultColorStyle"; // Metadata: 0x00B1242C
    private static ColorStyle _colorStyle; // 0x40
    private const string SKYBOX_STYLE_ASSET_PATH = "Data/UI/DefaultSkyBoxStyle"; // Metadata: 0x00B12449
    private static UISkyBoxStyle _skyBoxStyle; // 0x48
    private const string AVATAR_QUALITY_STYLE_ASSET_PATH = "Data/UI/DefaultAvatarQualityStyle"; // Metadata: 0x00B12467
    private static AvatarQualityStyle _avatarQualityStyle; // 0x50
    private const string EQUIP_RARITY_STYLE_ASSET_PATH = "Data/UI/DefaultEquipRarityStyle"; // Metadata: 0x00B1248C
    private static EquipRarityStyle _equipRarityStyle; // 0x58
    private const string BAG_TAB_CONFIG_ASSET_PATH = "Data/UI/DefaultBagTabConfig"; // Metadata: 0x00B124AF
    private static BagTabConfig _bagTabConfig; // 0x60
    private const string COOK_TAB_CONFIG_ASSET_PATH = "Data/UI/DefaultCookTabConfig"; // Metadata: 0x00B124CE
    private static CookTabConfig _cookTabConfig; // 0x68
    private const string QUEST_TYPE_TAB_CONFIG_ASSET_PATH = "Data/UI/DefaultQuestTypeTabConfig"; // Metadata: 0x00B124EE
    private static QuestTypeTabConfig _questTypeTabConfig; // 0x70
    private const string FRIEND_TAB_CONFIG_ASSET_PATH = "Data/UI/DefaultFriendTabConfig"; // Metadata: 0x00B12513
    private static FriendTabConfig _friendTabConfig; // 0x78
    private const string EQUIP_LEVEL_UP_STYLE_ASSET_PATH = "Data/UI/DefaultEquipLevelUpStyle"; // Metadata: 0x00B12535
    private static EquipLevelUpEffectStyle _equipLevelUpStyle; // 0x80
    private const string XBOX_JOYPAD_INPUT_SETTING_ASSET_PATH = "Data/UI/XboxJoypadInputSetting"; // Metadata: 0x00B12559
    private const string PS4_JOYPAD_INPUT_SETTING_ASSET_PATH = "Data/UI/PS4JoypadInputSetting"; // Metadata: 0x00B1257B
    private const string ENVIRO_CURVE_ASSET_PATH = "Data/Environment/Config/EnviroCurveConfig"; // Metadata: 0x00B1259C
    private static EnviroCurveConfig _enviroCurveConfig; // 0xA0
    private const string GENERAL_ICON_CONFIG_ASSET_PATH = "Data/UI/GeneralIconConfig"; // Metadata: 0x00B125C9
    private static GeneralIconConfig _generalIconConfig; // 0xA8

    // Properties
    public static JoypadInputSetting xboxJoypadSetting { /* [XID] */ /* 0x0000000189857A60-0x0000000189857AA0 */ get; /* [XID] */ /* 0x00000001898621A0-0x00000001898621E0 */ private set; } // 0x0000000183D7EA50-0x0000000183D7EAE0 0x0000000183D7BFA0-0x0000000183D7C030
    public static JoypadInputSetting ps4JoypadSetting { /* [XID] */ /* 0x000000018986C4D0-0x000000018986C510 */ get; /* [XID] */ /* 0x0000000189876920-0x0000000189876960 */ private set; } // 0x0000000183D7C3C0-0x0000000183D7C450 0x0000000183D7BB80-0x0000000183D7BC10
    private static string UNKNOWN_JOYPAD_INPUT_SETTING_ASSET_PATH { /* [XID] */ /* 0x0000000189BB1AE0-0x0000000189BB1B00 */ get; } // 0x0000000183D80960-0x0000000183D80AF0 
    public static JoypadInputSetting unknownJoypadSetting { /* [XID] */ /* 0x00000001898885E0-0x0000000189888620 */ get; /* [XID] */ /* 0x00000001898929B0-0x00000001898929F0 */ private set; } // 0x0000000183D800C0-0x0000000183D80150 0x0000000183D7DF40-0x0000000183D7DFD0
    public static ColorStyle colorStyle { /* [XID] */ /* 0x000000018995B680-0x000000018995B6A0 */ get; } // 0x0000000183D7B9E0-0x0000000183D7BAB0 
    public static BagTabConfig bagTabConfig { /* [XID] */ /* 0x0000000189963260-0x0000000189963280 */ get; } // 0x0000000183D80AF0-0x0000000183D80BC0 
    public static CookTabConfig cookTabConfig { /* [XID] */ /* 0x000000018996A620-0x000000018996A640 */ get; } // 0x0000000183D7DFD0-0x0000000183D7E0A0 
    public static QuestTypeTabConfig questTypeTabConfig { /* [XID] */ /* 0x0000000189972360-0x0000000189972380 */ get; } // 0x0000000183D7D8B0-0x0000000183D7D980 
    public static FriendTabConfig friendTabConfig { /* [XID] */ /* 0x0000000189979B00-0x0000000189979B20 */ get; } // 0x0000000183D7EB70-0x0000000183D7EC40 
    public static PropertyFormatStyle propertyFormatStyle { /* [XID] */ /* 0x0000000189981330-0x0000000189981350 */ get; } // 0x0000000183D7D980-0x0000000183D7DA50 
    public static EnviroCurveConfig enviroCurveConfig { /* [XID] */ /* 0x0000000189988B00-0x0000000189988B20 */ get; } // 0x0000000183D7BAB0-0x0000000183D7BB80 
    public static GeneralIconConfig generalIconConfig { /* [XID] */ /* 0x00000001899902A0-0x00000001899902C0 */ get; } // 0x0000000183D80BC0-0x0000000183D80C90 

    // Constructors
    static AssetConfigUtils() { } // 0x0000000183D80C90-0x0000000183D80E40

    // Methods
    // [XID] // 0x0000000189B9B8C0-0x0000000189B9B8E0
    public static void LoadForJoyPad() { } // 0x0000000183D802B0-0x0000000183D80590
                                           // [XID] // 0x00000001898A4540-0x00000001898A4560
    public static void LoadAllConfigs() { } // 0x0000000183D7EDE0-0x0000000183D7FDF0
                                            // [XID] // 0x00000001898AB9D0-0x00000001898AB9F0
    public static void LoadGlobalConfigs() { } // 0x0000000183D7E770-0x0000000183D7EA50
                                               // [XID] // 0x00000001898B3190-0x00000001898B31B0
    public static void LoadEmbededConfigs() {/* 纯热更新 */} // 0x0000000183D7EAE0-0x0000000183D7EB70
                                                         // [XID] // 0x00000001898BAEB0-0x00000001898BAED0
    public static void UnloadAllConfigs() { } // 0x0000000183D7CA40-0x0000000183D7D8B0
                                              // [XID] // 0x00000001898C21E0-0x00000001898C2200
    public static AvatarAssociationInfo.AssocInfo GetAssocInfo(AssocType assocType) => default; // 0x0000000183D80150-0x0000000183D802B0
                                                                                                // [XID] // 0x00000001898C9C80-0x00000001898C9CA0
    public static ElementStyle.Style GetElementStyle(ElementType elemType) => default; // 0x0000000183D7BC10-0x0000000183D7BFA0
                                                                                       // [XID] // 0x00000001898D1240-0x00000001898D1260
    public static ElementReactionStyle.Style GetElementReactionStyle(ElementReactionType elemReactionType) => default; // 0x0000000183D7EC40-0x0000000183D7EDE0
                                                                                                                       // [IDTag] // 0x00000001898D8AD0-0x00000001898D8B10
                                                                                                                       // [XID] // 0x00000001898D8AD0-0x00000001898D8B10
    public static AvatarElementStyle.Style GetAvatarElementStyle(uint configID, ElementType elemType) => default; // 0x0000000183D7B870-0x0000000183D7B9E0
                                                                                                                  // [XID] // 0x000000018981F850-0x000000018981F870
    public static AvatarElementStyle.AvatarMaterial GetAvatarMaterial(uint configID) => default; // 0x0000000183D7C8E0-0x0000000183D7CA40
                                                                                                 // [IDTag] // 0x00000001898EB300-0x00000001898EB340
                                                                                                 // [XID] // 0x00000001898EB300-0x00000001898EB340
    public static AvatarElementStyle.AvatarStyle GetAvatarElementStyle(uint configID) => default; // 0x0000000183D7B710-0x0000000183D7B870
                                                                                                  // [IDTag] // 0x00000001898F5AA0-0x00000001898F5AE0
                                                                                                  // [XID] // 0x00000001898F5AA0-0x00000001898F5AE0
    public static EquipElementStyle.Style GetEquipElementStyle(uint configID, ElementType elemType) => default; // 0x0000000183D7FDF0-0x0000000183D7FF60
                                                                                                                // [IDTag] // 0x0000000189900550-0x0000000189900590
                                                                                                                // [XID] // 0x0000000189900550-0x0000000189900590
    public static EquipElementStyle.EquipStyle GetEquipElementStyle(uint configID) => default; // 0x0000000183D7FF60-0x0000000183D800C0
                                                                                               // [XID] // 0x000000018990A8E0-0x000000018990A900
    public static CharacterViewStyle.Style GetCharacterViewStyle(uint configId) => default; // 0x0000000183D7C5B0-0x0000000183D7C8E0
                                                                                            // [XID] // 0x0000000189912530-0x0000000189912550
    public static BodyCameraStyle.Style GetBodyCameraStyle(BodyType type) => default; // 0x0000000183D80590-0x0000000183D80960
                                                                                      // [XID] // 0x0000000189919E40-0x0000000189919E60
    public static UISkyBoxStyle.Style GetSkyBoxStyle(SkyBoxType skyBoxType) => default; // 0x0000000183D7E460-0x0000000183D7E770
                                                                                        // [XID] // 0x0000000189921680-0x00000001899216A0
    public static AvatarQualityStyle.Style GetAvatarQualityStyle(QualityType qualityType) => default; // 0x0000000183D7DD50-0x0000000183D7DF40
                                                                                                      // [XID] // 0x0000000189928DA0-0x0000000189928DC0
    public static EquipRarityStyle.Style GetEquipRarityStyle(QualityType qualityType) => default; // 0x0000000183D7C030-0x0000000183D7C3C0
                                                                                                  // [XID] // 0x00000001899302D0-0x00000001899302F0
    public static EquipLevelUpEffectStyle.Style GetEquipLevelUpStyle(WeaponType weaponType) => default; // 0x0000000183D7DA50-0x0000000183D7DC40
                                                                                                        // [XID] // 0x0000000189937790-0x00000001899377B0
    private static PropFormat GetPropertyFormat(FightPropType propType) => default; // 0x0000000183D7C450-0x0000000183D7C5B0
                                                                                    // [XID] // 0x000000018993F2B0-0x000000018993F2D0
    public static string GetFormatString(PropFormat format) => default; // 0x0000000183D7DC40-0x0000000183D7DD50
                                                                        // [IDTag] // 0x0000000189946860-0x00000001899468A0
                                                                        // [XID] // 0x0000000189946860-0x00000001899468A0
    public static string FormatProperty(FightPropType propertyType, float value) => default; // 0x0000000183D7E370-0x0000000183D7E460
                                                                                             // [IDTag] // 0x0000000189951200-0x0000000189951240
                                                                                             // [XID] // 0x0000000189951200-0x0000000189951240
    public static string FormatProperty(PropFormat format, float value) => default; // 0x0000000183D7E0A0-0x0000000183D7E370
}

