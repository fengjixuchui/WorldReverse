/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using ChillyRoom.UnityEditor.iOS.Xcode.PBX;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	public class PBXProject // TypeDefIndex: 10417
	{
		// Fields
		private PBXProjectData m_Data; // 0x10
	
		// Properties
		internal KnownSectionBase<PBXContainerItemProxyData> containerItems { /* [XID] */ /* 0x00000001896B2280-0x00000001896B22A0 */ get => default; } // 0x0000000186D3F940-0x0000000186D3F9F0 
		internal KnownSectionBase<PBXReferenceProxyData> references { /* [XID] */ /* 0x0000000189B115E0-0x0000000189B11600 */ get => default; } // 0x0000000186D3FCB0-0x0000000186D3FD60 
		internal KnownSectionBase<PBXSourcesBuildPhaseData> sources { /* [XID] */ /* 0x00000001896C1020-0x00000001896C1040 */ get => default; } // 0x0000000186D3FEC0-0x0000000186D3FF70 
		internal KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks { /* [XID] */ /* 0x0000000189B1FEB0-0x0000000189B1FED0 */ get => default; } // 0x0000000186D3FAA0-0x0000000186D3FB50 
		internal KnownSectionBase<PBXResourcesBuildPhaseData> resources { /* [XID] */ /* 0x00000001896CFF50-0x00000001896CFF70 */ get => default; } // 0x0000000186D3FD60-0x0000000186D3FE10 
		internal KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles { /* [XID] */ /* 0x00000001896D73C0-0x00000001896D73E0 */ get => default; } // 0x0000000186D3F9F0-0x0000000186D3FAA0 
		internal KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts { /* [XID] */ /* 0x0000000189A8B510-0x0000000189A8B530 */ get => default; } // 0x0000000186D3FE10-0x0000000186D3FEC0 
		internal KnownSectionBase<PBXNativeTargetData> nativeTargets { /* [XID] */ /* 0x0000000189B2E800-0x0000000189B2E820 */ get => default; } // 0x0000000186D3FB50-0x0000000186D3FC00 
		internal KnownSectionBase<PBXTargetDependencyData> targetDependencies { /* [XID] */ /* 0x00000001896ED4C0-0x00000001896ED4E0 */ get => default; } // 0x0000000186D3FF70-0x0000000186D40020 
		internal KnownSectionBase<PBXVariantGroupData> variantGroups { /* [XID] */ /* 0x0000000189A92AE0-0x0000000189A92B00 */ get => default; } // 0x0000000186D40020-0x0000000186D400D0 
		internal KnownSectionBase<XCBuildConfigurationData> buildConfigs { /* [XID] */ /* 0x0000000189B35E90-0x0000000189B35EB0 */ get => default; } // 0x0000000186D3F890-0x0000000186D3F940 
		internal KnownSectionBase<XCConfigurationListData> buildConfigLists { /* [XID] */ /* 0x0000000189703B40-0x0000000189703B60 */ get => default; } // 0x0000000186D3F7E0-0x0000000186D3F890 
		internal PBXProjectSection project { /* [XID] */ /* 0x000000018970B270-0x000000018970B290 */ get => default; } // 0x0000000186D3FC00-0x0000000186D3FCB0 
	
		// Constructors
		public PBXProject() {} // 0x0000000186D3F750-0x0000000186D3F7E0
	
		// Methods
		// [XID] // 0x0000000189A5C880-0x0000000189A5C8A0
		internal PBXBuildFileData BuildFilesGet(string guid) => default; // 0x0000000186D37160-0x0000000186D37230
		// [XID] // 0x00000001898C9700-0x00000001898C9720
		internal void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile) {} // 0x0000000186D36EF0-0x0000000186D36FD0
		// [XID] // 0x00000001898D0FC0-0x00000001898D0FE0
		internal void BuildFilesRemove(string targetGuid, string fileGuid) {} // 0x0000000186D37230-0x0000000186D37310
		// [XID] // 0x0000000189B5BC40-0x0000000189B5BC60
		internal PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid) => default; // 0x0000000186D37080-0x0000000186D37160
		// [XID] // 0x0000000189730730-0x0000000189730750
		internal IEnumerable<PBXBuildFileData> BuildFilesGetAll() => default; // 0x0000000186D36FD0-0x0000000186D37080
		// [XID] // 0x0000000189737F30-0x0000000189737F50
		internal void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef) {} // 0x0000000186D37CA0-0x0000000186D37DB0
		// [XID] // 0x000000018973FB00-0x000000018973FB20
		internal PBXFileReferenceData FileRefsGet(string guid) => default; // 0x0000000186D37F60-0x0000000186D38030
		// [XID] // 0x0000000189B86E90-0x0000000189B86EB0
		internal PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree) => default; // 0x0000000186D37E80-0x0000000186D37F60
		// [XID] // 0x0000000189B8E020-0x0000000189B8E040
		internal PBXFileReferenceData FileRefsGetByProjectPath(string path) => default; // 0x0000000186D37DB0-0x0000000186D37E80
		// [XID] // 0x00000001897B6290-0x00000001897B62B0
		internal void FileRefsRemove(string guid) {} // 0x0000000186D38030-0x0000000186D380F0
		// [XID] // 0x000000018983D450-0x000000018983D470
		internal PBXGroupData GroupsGet(string guid) => default; // 0x0000000186D39AC0-0x0000000186D39B90
		// [XID] // 0x00000001897648E0-0x0000000189764900
		internal PBXGroupData GroupsGetByChild(string childGuid) => default; // 0x0000000186D397A0-0x0000000186D39870
		// [XID] // 0x000000018993A860-0x000000018993A880
		internal PBXGroupData GroupsGetMainGroup() => default; // 0x0000000186D39A10-0x0000000186D39AC0
		// [XID] // 0x0000000189BA41E0-0x0000000189BA4200
		internal PBXGroupData GroupsGetByProjectPath(string sourceGroup) => default; // 0x0000000186D39940-0x0000000186D39A10
		// [XID] // 0x000000018977B030-0x000000018977B050
		internal void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr) {} // 0x0000000186D396A0-0x0000000186D397A0
		// [XID] // 0x00000001897DBAB0-0x00000001897DBAD0
		internal void GroupsAddDuplicate(PBXGroupData gr) {} // 0x0000000186D395E0-0x0000000186D396A0
		// [XID] // 0x0000000189BAB7F0-0x0000000189BAB810
		internal void GroupsRemove(string guid) {} // 0x0000000186D39B90-0x0000000186D39C50
		// [XID] // 0x000000018997D440-0x000000018997D460
		private PBXGroupData GroupsGetByName(string name) => default; // 0x0000000186D39870-0x0000000186D39940
		// [IDTag] // 0x0000000189798CD0-0x0000000189798D10
		// [XID] // 0x0000000189798CD0-0x0000000189798D10
		internal FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef) => default; // 0x0000000186D37310-0x0000000186D37410
		// [IDTag] // 0x00000001897A3B90-0x00000001897A3BD0
		// [XID] // 0x00000001897A3B90-0x00000001897A3BD0
		internal FileGUIDListBase BuildSectionAny(string sectionGuid) => default; // 0x0000000186D37410-0x0000000186D374E0
		// [XID] // 0x00000001897AE280-0x00000001897AE2A0
		public static string GetPBXProjectPath(string buildPath) => default; // 0x0000000186D39250-0x0000000186D39300
		// [XID] // 0x00000001897B63B0-0x00000001897B63D0
		public static string GetUnityTargetName() => default; // 0x0000000186D394A0-0x0000000186D39540
		// [XID] // 0x0000000189BD0FB0-0x0000000189BD0FD0
		public static string GetUnityTestTargetName() => default; // 0x0000000186D39540-0x0000000186D395E0
		// [XID] // 0x00000001897C5830-0x00000001897C5850
		public string ProjectGuid() => default; // 0x0000000186D39DF0-0x0000000186D39EC0
		// [XID] // 0x0000000189BD85E0-0x0000000189BD8600
		public string TargetGuidByName(string name) => default; // 0x0000000186D3E5C0-0x0000000186D3E890
		// [XID] // 0x00000001897D4540-0x00000001897D4560
		public static bool IsKnownExtension(string ext) => default; // 0x0000000186D39D20-0x0000000186D39DF0
		// [XID] // 0x0000000189B7AAB0-0x0000000189B7AAD0
		public static bool IsBuildable(string ext) => default; // 0x0000000186D39C50-0x0000000186D39D20
		// [XID] // 0x00000001897E3710-0x00000001897E3730
		private string AddFileImpl(string path, string projectPath, PBXSourceTree tree, bool isFolderReference) => default; // 0x0000000186D34860-0x0000000186D34B00
		// [XID] // 0x00000001895FBA40-0x00000001895FBA60
		public string AddFile(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x00AE75AD */) => default; // 0x0000000186D35220-0x0000000186D35350
		// [XID] // 0x00000001899EE4F0-0x00000001899EE510
		public string AddFolderReference(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x00AE75B1 */) => default; // 0x0000000186D35350-0x0000000186D35480
		// [XID] // 0x00000001897FA490-0x00000001897FA4B0
		private void AddBuildFileImpl(string targetGuid, string fileGuid, bool weak, string compileFlags) {} // 0x0000000186D32F40-0x0000000186D331C0
		// [XID] // 0x0000000189801A10-0x0000000189801A30
		public void AddFileToBuild(string targetGuid, string fileGuid) {} // 0x0000000186D34E80-0x0000000186D34F60
		// [XID] // 0x0000000189808E70-0x0000000189808E90
		public void AddFileToBuildWithFlags(string targetGuid, string fileGuid, string compileFlags) {} // 0x0000000186D34D90-0x0000000186D34E80
		// [XID] // 0x00000001899BA110-0x00000001899BA130
		public void AddFileToBuildSection(string targetGuid, string sectionGuid, string fileGuid) {} // 0x0000000186D34C30-0x0000000186D34D90
		// [XID] // 0x0000000189817E80-0x0000000189817EA0
		public List<string> GetCompileFlagsForFile(string targetGuid, string fileGuid) => default; // 0x0000000186D38640-0x0000000186D387E0
		// [XID] // 0x000000018981F750-0x000000018981F770
		public void SetCompileFlagsForFile(string targetGuid, string fileGuid, List<string> compileFlags) {} // 0x0000000186D3D9A0-0x0000000186D3DAF0
		// [XID] // 0x0000000189612170-0x0000000189612190
		public void AddAssetTagForFile(string targetGuid, string fileGuid, string tag) {} // 0x0000000186D32840-0x0000000186D32A10
		// [XID] // 0x00000001899C1C80-0x00000001899C1CA0
		public void RemoveAssetTagForFile(string targetGuid, string fileGuid, string tag) {} // 0x0000000186D3A120-0x0000000186D3A390
		// [XID] // 0x0000000189835B50-0x0000000189835B70
		public void AddAssetTagToDefaultInstall(string targetGuid, string tag) {} // 0x0000000186D32A10-0x0000000186D32B40
		// [XID] // 0x000000018983D1A0-0x000000018983D1C0
		public void RemoveAssetTagFromDefaultInstall(string targetGuid, string tag) {} // 0x0000000186D3A390-0x0000000186D3A4F0
		// [XID] // 0x0000000189844990-0x00000001898449B0
		public void RemoveAssetTag(string tag) {} // 0x0000000186D3A4F0-0x0000000186D3A920
		// [IDTag] // 0x000000018984BE10-0x000000018984BE50
		// [XID] // 0x000000018984BE10-0x000000018984BE50
		public bool ContainsFileByRealPath(string path) => default; // 0x0000000186D376C0-0x0000000186D37780
		// [IDTag] // 0x0000000189855E50-0x0000000189855E90
		// [XID] // 0x0000000189855E50-0x0000000189855E90
		public bool ContainsFileByRealPath(string path, PBXSourceTree sourceTree) => default; // 0x0000000186D375A0-0x0000000186D376C0
		// [XID] // 0x000000018963EF50-0x000000018963EF70
		public bool ContainsFileByProjectPath(string path) => default; // 0x0000000186D374E0-0x0000000186D375A0
		// [XID] // 0x00000001899493D0-0x00000001899493F0
		public bool ContainsFramework(string targetGuid, string framework) => default; // 0x0000000186D37780-0x0000000186D378B0
		// [XID] // 0x000000018986F100-0x000000018986F120
		public void AddFrameworkToProject(string targetGuid, string framework, bool weak) {} // 0x0000000186D35480-0x0000000186D355F0
		// [XID] // 0x0000000189876590-0x00000001898765B0
		public void RemoveFrameworkFromProject(string targetGuid, string framework) {} // 0x0000000186D3C7B0-0x0000000186D3C8D0
		// [XID] // 0x000000018987E2D0-0x000000018987E2F0
		public bool AddCapability(string targetGuid, PBXCapabilityType capability, string entitlementsFilePath = null, bool addOptionalFramework = false /* Metadata: 0x00AE75B5 */) => default; // 0x0000000186D33940-0x0000000186D33E40
		// [XID] // 0x00000001898852B0-0x00000001898852D0
		public void SetTeamId(string targetGuid, string teamId) {} // 0x0000000186D3DF50-0x0000000186D3E080
		// [IDTag] // 0x000000018988C800-0x000000018988C840
		// [XID] // 0x000000018988C800-0x000000018988C840
		public string FindFileGuidByRealPath(string path, PBXSourceTree sourceTree) => default; // 0x0000000186D383C0-0x0000000186D384F0
		// [IDTag] // 0x0000000189896C00-0x0000000189896C40
		// [XID] // 0x0000000189896C00-0x0000000189896C40
		public string FindFileGuidByRealPath(string path) => default; // 0x0000000186D381C0-0x0000000186D383C0
		// [XID] // 0x00000001898A1010-0x00000001898A1030
		public string FindFileGuidByProjectPath(string path) => default; // 0x0000000186D380F0-0x0000000186D381C0
		// [XID] // 0x000000018965D080-0x000000018965D0A0
		public void RemoveFileFromBuild(string targetGuid, string fileGuid) {} // 0x0000000186D3BB20-0x0000000186D3C420
		// [XID] // 0x0000000189A54F70-0x0000000189A54F90
		public void RemoveFile(string fileGuid) {} // 0x0000000186D3C420-0x0000000186D3C6D0
		// [XID] // 0x00000001896199F0-0x0000000189619A10
		private void RemoveGroupIfEmpty(PBXGroupData gr) {} // 0x0000000186D3CC60-0x0000000186D3CDB0
		// [XID] // 0x0000000189664630-0x0000000189664650
		private void RemoveGroupChildrenRecursive(PBXGroupData parent) {} // 0x0000000186D3C8D0-0x0000000186D3CC60
		// [XID] // 0x00000001898C6660-0x00000001898C6680
		internal void RemoveFilesByProjectPathRecursive(string projectPath) {} // 0x0000000186D3C6D0-0x0000000186D3C7B0
		// [XID] // 0x00000001896F0150-0x00000001896F0170
		internal List<string> GetGroupChildrenFiles(string projectPath) => default; // 0x0000000186D38E10-0x0000000186D39020
		// [XID] // 0x00000001898D56F0-0x00000001898D5710
		internal HashSet<string> GetGroupChildrenFilesRefs(string projectPath) => default; // 0x0000000186D38BD0-0x0000000186D38E10
		// [XID] // 0x00000001896F7A10-0x00000001896F7A30
		internal HashSet<string> GetFileRefsByProjectPaths(IEnumerable<string> paths) => default; // 0x0000000186D38970-0x0000000186D38BD0
		// [XID] // 0x00000001899A3A00-0x00000001899A3A20
		private PBXGroupData GetPBXGroupChildByName(PBXGroupData group, string name) => default; // 0x0000000186D39020-0x0000000186D39250
		// [XID] // 0x00000001895F4210-0x00000001895F4230
		private PBXGroupData CreateSourceGroup(string sourceGroup) => default; // 0x0000000186D37A00-0x0000000186D37CA0
		// [XID] // 0x0000000189A0C250-0x0000000189A0C270
		internal void AddExternalProjectDependency(string path, string projectPath, PBXSourceTree sourceTree) {} // 0x0000000186D345E0-0x0000000186D34860
		// [XID] // 0x0000000189A13BD0-0x0000000189A13BF0
		internal void AddExternalLibraryDependency(string targetGuid, string filename, string remoteFileGuid, string projectPath, string remoteInfo) {} // 0x0000000186D33FF0-0x0000000186D345E0
		// [XID] // 0x0000000189902F60-0x0000000189902F80
		public string AddTarget(string name, string ext, string type) => default; // 0x0000000186D35F50-0x0000000186D36340
		// [XID] // 0x000000018969F540-0x000000018969F560
		private IEnumerable<string> GetAllTargetGuids() => default; // 0x0000000186D384F0-0x0000000186D38640
		// [XID] // 0x00000001896A6900-0x00000001896A6920
		public string GetTargetProductFileRef(string targetGuid) => default; // 0x0000000186D393C0-0x0000000186D394A0
		// [XID] // 0x0000000189919AA0-0x0000000189919AC0
		internal void AddTargetDependency(string targetGuid, string targetDependencyGuid) {} // 0x0000000186D35CD0-0x0000000186D35F50
		// [XID] // 0x0000000189920FB0-0x0000000189920FD0
		private string AddBuildConfigForTarget(string targetGuid, string name) => default; // 0x0000000186D32B40-0x0000000186D32D50
		// [XID] // 0x00000001899289D0-0x00000001899289F0
		private void RemoveBuildConfigForTarget(string targetGuid, string name) {} // 0x0000000186D3A920-0x0000000186D3AA90
		// [XID] // 0x000000018992FE10-0x000000018992FE30
		public string BuildConfigByName(string targetGuid, string name) => default; // 0x0000000186D36980-0x0000000186D36C10
		// [XID] // 0x0000000189937330-0x0000000189937350
		public IEnumerable<string> BuildConfigNames() => default; // 0x0000000186D36C10-0x0000000186D36EF0
		// [XID] // 0x000000018993EEA0-0x000000018993EEC0
		public void AddBuildConfig(string name) {} // 0x0000000186D32D50-0x0000000186D32F40
		// [XID] // 0x00000001899DE6F0-0x00000001899DE710
		public void RemoveBuildConfig(string name) {} // 0x0000000186D3AA90-0x0000000186D3AC80
		// [XID] // 0x00000001896BC8E0-0x00000001896BC900
		public string AddSourcesBuildPhase(string targetGuid) => default; // 0x0000000186D35B80-0x0000000186D35CD0
		// [XID] // 0x00000001897AE1C0-0x00000001897AE1E0
		public string AddResourcesBuildPhase(string targetGuid) => default; // 0x0000000186D35A30-0x0000000186D35B80
		// [XID] // 0x000000018980BB50-0x000000018980BB70
		public string AddFrameworksBuildPhase(string targetGuid) => default; // 0x0000000186D355F0-0x0000000186D35740
		// [XID] // 0x00000001899642F0-0x0000000189964310
		public string AddCopyFilesBuildPhase(string targetGuid, string name, string dstPath, string subfolderSpec) => default; // 0x0000000186D33E40-0x0000000186D33FF0
		// [XID] // 0x0000000189AA15C0-0x0000000189AA15E0
		internal string GetConfigListForTarget(string targetGuid) => default; // 0x0000000186D387E0-0x0000000186D38970
		// [XID] // 0x00000001899734D0-0x00000001899734F0
		internal void SetBaseReferenceForConfig(string configGuid, string baseReference) {} // 0x0000000186D3D120-0x0000000186D3D220
		// [IDTag] // 0x000000018997ACE0-0x000000018997AD20
		// [XID] // 0x000000018997ACE0-0x000000018997AD20
		public void AddBuildProperty(string targetGuid, string name, string value) {} // 0x0000000186D336F0-0x0000000186D33940
		// [IDTag] // 0x00000001899851E0-0x0000000189985220
		// [XID] // 0x00000001899851E0-0x0000000189985220
		public void AddBuildProperty(IEnumerable<string> targetGuids, string name, string value) {} // 0x0000000186D334E0-0x0000000186D336F0
		// [IDTag] // 0x000000018998FDC0-0x000000018998FE00
		// [XID] // 0x000000018998FDC0-0x000000018998FE00
		public void AddBuildPropertyForConfig(string configGuid, string name, string value) {} // 0x0000000186D333D0-0x0000000186D334E0
		// [IDTag] // 0x000000018999AC50-0x000000018999AC90
		// [XID] // 0x000000018999AC50-0x000000018999AC90
		public void AddBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value) {} // 0x0000000186D331C0-0x0000000186D333D0
		// [IDTag] // 0x00000001899A53A0-0x00000001899A53E0
		// [XID] // 0x00000001899A53A0-0x00000001899A53E0
		public void SetBuildProperty(string targetGuid, string name, string value) {} // 0x0000000186D3D540-0x0000000186D3D790
		// [IDTag] // 0x00000001899AFD50-0x00000001899AFD90
		// [XID] // 0x00000001899AFD50-0x00000001899AFD90
		public void SetBuildProperty(IEnumerable<string> targetGuids, string name, string value) {} // 0x0000000186D3D790-0x0000000186D3D9A0
		// [IDTag] // 0x00000001899BA2A0-0x00000001899BA2E0
		// [XID] // 0x00000001899BA2A0-0x00000001899BA2E0
		public void SetBuildPropertyForConfig(string configGuid, string name, string value) {} // 0x0000000186D3D220-0x0000000186D3D330
		// [IDTag] // 0x00000001899C4DD0-0x00000001899C4E10
		// [XID] // 0x00000001899C4DD0-0x00000001899C4E10
		public void SetBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value) {} // 0x0000000186D3D330-0x0000000186D3D540
		// [IDTag] // 0x00000001899CF4F0-0x00000001899CF530
		// [XID] // 0x00000001899CF4F0-0x00000001899CF530
		internal void RemoveBuildProperty(string targetGuid, string name) {} // 0x0000000186D3B6F0-0x0000000186D3B930
		// [IDTag] // 0x00000001899D99E0-0x00000001899D9A20
		// [XID] // 0x00000001899D99E0-0x00000001899D9A20
		internal void RemoveBuildProperty(IEnumerable<string> targetGuids, string name) {} // 0x0000000186D3B930-0x0000000186D3BB20
		// [IDTag] // 0x00000001899E4040-0x00000001899E4080
		// [XID] // 0x00000001899E4040-0x00000001899E4080
		internal void RemoveBuildPropertyForConfig(string configGuid, string name) {} // 0x0000000186D3AC80-0x0000000186D3AD80
		// [IDTag] // 0x00000001899EE690-0x00000001899EE6D0
		// [XID] // 0x00000001899EE690-0x00000001899EE6D0
		internal void RemoveBuildPropertyForConfig(IEnumerable<string> configGuids, string name) {} // 0x0000000186D3AD80-0x0000000186D3AF70
		// [IDTag] // 0x00000001899F8EB0-0x00000001899F8EF0
		// [XID] // 0x00000001899F8EB0-0x00000001899F8EF0
		internal void RemoveBuildPropertyValueList(string targetGuid, string name, IEnumerable<string> valueList) {} // 0x0000000186D3B290-0x0000000186D3B4E0
		// [IDTag] // 0x0000000189A03640-0x0000000189A03680
		// [XID] // 0x0000000189A03640-0x0000000189A03680
		internal void RemoveBuildPropertyValueList(IEnumerable<string> targetGuids, string name, IEnumerable<string> valueList) {} // 0x0000000186D3B4E0-0x0000000186D3B6F0
		// [IDTag] // 0x0000000189A0DD40-0x0000000189A0DD80
		// [XID] // 0x0000000189A0DD40-0x0000000189A0DD80
		internal void RemoveBuildPropertyValueListForConfig(string configGuid, string name, IEnumerable<string> valueList) {} // 0x0000000186D3B180-0x0000000186D3B290
		// [IDTag] // 0x0000000189A18070-0x0000000189A180B0
		// [XID] // 0x0000000189A18070-0x0000000189A180B0
		internal void RemoveBuildPropertyValueListForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> valueList) {} // 0x0000000186D3AF70-0x0000000186D3B180
		// [IDTag] // 0x0000000189A22880-0x0000000189A228C0
		// [XID] // 0x0000000189A22880-0x0000000189A228C0
		public void UpdateBuildProperty(string targetGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues) {} // 0x0000000186D3ED80-0x0000000186D3F000
		// [IDTag] // 0x0000000189A2C9A0-0x0000000189A2C9E0
		// [XID] // 0x0000000189A2C9A0-0x0000000189A2C9E0
		public void UpdateBuildProperty(IEnumerable<string> targetGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues) {} // 0x0000000186D3F000-0x0000000186D3F230
		// [IDTag] // 0x0000000189A373C0-0x0000000189A37400
		// [XID] // 0x0000000189A373C0-0x0000000189A37400
		public void UpdateBuildPropertyForConfig(string configGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues) {} // 0x0000000186D3EAC0-0x0000000186D3ED80
		// [IDTag] // 0x0000000189A41A90-0x0000000189A41AD0
		// [XID] // 0x0000000189A41A90-0x0000000189A41AD0
		public void UpdateBuildPropertyForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues) {} // 0x0000000186D3E890-0x0000000186D3EAC0
		// [XID] // 0x0000000189A4C030-0x0000000189A4C050
		internal string ShellScriptByName(string targetGuid, string name) => default; // 0x0000000186D3E080-0x0000000186D3E2F0
		// [IDTag] // 0x0000000189A53750-0x0000000189A53790
		// [XID] // 0x0000000189A53750-0x0000000189A53790
		internal void AppendShellScriptBuildPhase(string targetGuid, string name, string shellPath, string shellScript) {} // 0x0000000186D36550-0x0000000186D366D0
		// [IDTag] // 0x0000000189A5E2D0-0x0000000189A5E310
		// [XID] // 0x0000000189A5E2D0-0x0000000189A5E310
		internal void AppendShellScriptBuildPhase(IEnumerable<string> targetGuids, string name, string shellPath, string shellScript) {} // 0x0000000186D366D0-0x0000000186D36980
		// [XID] // 0x00000001896E19C0-0x00000001896E19E0
		public void ReadFromFile(string path) {} // 0x0000000186D39EC0-0x0000000186D39F80
		// [XID] // 0x00000001899B2F90-0x00000001899B2FB0
		public void ReadFromString(string src) {} // 0x0000000186D3A040-0x0000000186D3A120
		// [XID] // 0x0000000189A77AC0-0x0000000189A77AE0
		public void ReadFromStream(TextReader sr) {} // 0x0000000186D39F80-0x0000000186D3A040
		// [XID] // 0x0000000189AF7460-0x0000000189AF7480
		public void WriteToFile(string path) {} // 0x0000000186D3F500-0x0000000186D3F5C0
		// [XID] // 0x0000000189A86B20-0x0000000189A86B40
		public void WriteToStream(TextWriter sw) {} // 0x0000000186D3F5C0-0x0000000186D3F6A0
		// [XID] // 0x0000000189A8E6F0-0x0000000189A8E710
		public string WriteToString() => default; // 0x0000000186D3F6A0-0x0000000186D3F750
		// [XID] // 0x00000001897F5800-0x00000001897F5820
		internal PBXProjectObjectData GetProjectInternal() => default; // 0x0000000186D39300-0x0000000186D393C0
		// [XID] // 0x0000000189A9D3C0-0x0000000189A9D3E0
		public void AddLocalization(string variantGroupName, string locale, string path) {} // 0x0000000186D35740-0x0000000186D35A30
		// [XID] // 0x0000000189AA4B40-0x0000000189AA4B60
		private void AddToGroup(string name, string guid) {} // 0x0000000186D36340-0x0000000186D36430
		// [XID] // 0x0000000189AAC230-0x0000000189AAC250
		private PBXVariantGroupData AddVariantGroup(string name, PBXSourceTree sourceTree) => default; // 0x0000000186D36430-0x0000000186D36550
		// [XID] // 0x0000000189AB3AB0-0x0000000189AB3AD0
		private PBXVariantGroupData VariantGroupsGetByName(string name) => default; // 0x0000000186D3F230-0x0000000186D3F500
		// [XID] // 0x00000001896D1220-0x00000001896D1240
		private PBXVariantGroupData CreateLocalizableVariantGroup(string name) => default; // 0x0000000186D378B0-0x0000000186D37A00
		// [XID] // 0x000000018981AE50-0x000000018981AE70
		private void AddFileToResourceBuildPhase(string buildPhaseGuid, string fileGuid) {} // 0x0000000186D34F60-0x0000000186D35220
		// [XID] // 0x0000000189813300-0x0000000189813320
		private string AddFileRefToBuild(string target, string guid) => default; // 0x0000000186D34B00-0x0000000186D34C30
		// [XID] // 0x000000018984D360-0x000000018984D380
		private string ResourceBuildPhaseByTargetName(string name) => default; // 0x0000000186D3CDB0-0x0000000186D3D120
		// [XID] // 0x0000000189AD9A50-0x0000000189AD9A70
		private PBXNativeTargetData TargetByName(string name) => default; // 0x0000000186D3E2F0-0x0000000186D3E5C0
		// [XID] // 0x0000000189AE1610-0x0000000189AE1630
		internal void SetTargetAttributes(string key, string value) {} // 0x0000000186D3DAF0-0x0000000186D3DF50
	}
}
