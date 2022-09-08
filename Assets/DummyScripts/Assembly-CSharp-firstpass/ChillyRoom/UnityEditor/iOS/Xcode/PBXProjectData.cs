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
	internal class PBXProjectData // TypeDefIndex: 10418
	{
		// Fields
		private Dictionary<string, SectionBase> m_Section; // 0x10
		private PBXElementDict m_RootElements; // 0x18
		private PBXElementDict m_UnknownObjects; // 0x20
		private string m_ObjectVersion; // 0x28
		private List<string> m_SectionOrder; // 0x30
		private Dictionary<string, KnownSectionBase<PBXObjectData>> m_UnknownSections; // 0x38
		private KnownSectionBase<PBXBuildFileData> buildFiles; // 0x40
		private KnownSectionBase<PBXFileReferenceData> fileRefs; // 0x48
		private KnownSectionBase<PBXGroupData> groups; // 0x50
		public KnownSectionBase<PBXContainerItemProxyData> containerItems; // 0x58
		public KnownSectionBase<PBXReferenceProxyData> references; // 0x60
		public KnownSectionBase<PBXSourcesBuildPhaseData> sources; // 0x68
		public KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks; // 0x70
		public KnownSectionBase<PBXResourcesBuildPhaseData> resources; // 0x78
		public KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles; // 0x80
		public KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts; // 0x88
		public KnownSectionBase<PBXNativeTargetData> nativeTargets; // 0x90
		public KnownSectionBase<PBXTargetDependencyData> targetDependencies; // 0x98
		public KnownSectionBase<PBXVariantGroupData> variantGroups; // 0xA0
		public KnownSectionBase<XCBuildConfigurationData> buildConfigs; // 0xA8
		public KnownSectionBase<XCConfigurationListData> buildConfigLists; // 0xB0
		public PBXProjectSection project; // 0xB8
		private Dictionary<string, Dictionary<string, PBXBuildFileData>> m_FileGuidToBuildFileMap; // 0xC0
		private Dictionary<string, PBXFileReferenceData> m_ProjectPathToFileRefMap; // 0xC8
		private Dictionary<string, string> m_FileRefGuidToProjectPathMap; // 0xD0
		private Dictionary<PBXSourceTree, Dictionary<string, PBXFileReferenceData>> m_RealPathToFileRefMap; // 0xD8
		private Dictionary<string, PBXGroupData> m_ProjectPathToGroupMap; // 0xE0
		private Dictionary<string, string> m_GroupGuidToProjectPathMap; // 0xE8
		private Dictionary<string, PBXGroupData> m_GuidToParentGroupMap; // 0xF0
	
		// Constructors
		public PBXProjectData() {} // 0x0000000186D308E0-0x0000000186D309E0
	
		// Methods
		// [XID] // 0x0000000189B45480-0x0000000189B454A0
		public PBXBuildFileData BuildFilesGet(string guid) => default; // 0x0000000186D29FD0-0x0000000186D2A0A0
		// [XID] // 0x0000000189B33010-0x0000000189B33030
		public void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile) {} // 0x0000000186D29BE0-0x0000000186D29D90
		// [XID] // 0x0000000189B3AAE0-0x0000000189B3AB00
		public void BuildFilesRemove(string targetGuid, string fileGuid) {} // 0x0000000186D2A0A0-0x0000000186D2A1E0
		// [XID] // 0x0000000189B422F0-0x0000000189B42310
		public PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid) => default; // 0x0000000186D29E50-0x0000000186D29FD0
		// [XID] // 0x0000000189B630A0-0x0000000189B630C0
		public IEnumerable<PBXBuildFileData> BuildFilesGetAll() => default; // 0x0000000186D29D90-0x0000000186D29E50
		// [XID] // 0x0000000189B51470-0x0000000189B51490
		public void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef) {} // 0x0000000186D2B380-0x0000000186D2B580
		// [XID] // 0x0000000189B58E80-0x0000000189B58EA0
		public IEnumerable<PBXFileReferenceData> FileRefsGetAll() => default; // 0x0000000186D2B580-0x0000000186D2B640
		// [XID] // 0x0000000189B7F300-0x0000000189B7F320
		public PBXFileReferenceData FileRefsGet(string guid) => default; // 0x0000000186D2B890-0x0000000186D2B960
		// [XID] // 0x000000018976A9F0-0x000000018976AA10
		public PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree) => default; // 0x0000000186D2B740-0x0000000186D2B890
		// [XID] // 0x0000000189771FD0-0x0000000189771FF0
		public PBXFileReferenceData FileRefsGetByProjectPath(string path) => default; // 0x0000000186D2B640-0x0000000186D2B740
		// [XID] // 0x0000000189A0E160-0x0000000189A0E180
		public void FileRefsRemove(string guid) {} // 0x0000000186D2B960-0x0000000186D2BC50
		// [XID] // 0x0000000189B954A0-0x0000000189B954C0
		public PBXGroupData GroupsGet(string guid) => default; // 0x0000000186D2C420-0x0000000186D2C4F0
		// [XID] // 0x0000000189B9CB30-0x0000000189B9CB50
		public PBXGroupData GroupsGetByChild(string childGuid) => default; // 0x0000000186D2BE90-0x0000000186D2BF60
		// [XID] // 0x0000000189941910-0x0000000189941930
		public PBXGroupData GroupsGetMainGroup() => default; // 0x0000000186D2C320-0x0000000186D2C420
		// [XID] // 0x000000018995FB30-0x000000018995FB50
		public PBXGroupData GroupsGetByProjectPath(string sourceGroup) => default; // 0x0000000186D2C220-0x0000000186D2C320
		// [XID] // 0x0000000189B9B6F0-0x0000000189B9B710
		public void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr) {} // 0x0000000186D2BD20-0x0000000186D2BE90
		// [XID] // 0x0000000189BA2E50-0x0000000189BA2E70
		public void GroupsAddDuplicate(PBXGroupData gr) {} // 0x0000000186D2BC50-0x0000000186D2BD20
		// [XID] // 0x0000000189BB2D90-0x0000000189BB2DB0
		public void GroupsRemove(string guid) {} // 0x0000000186D2C4F0-0x0000000186D2C650
		// [IDTag] // 0x0000000189BB19E0-0x0000000189BB1A20
		// [XID] // 0x0000000189BB19E0-0x0000000189BB1A20
		public FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef) => default; // 0x0000000186D2A410-0x0000000186D2AA10
		// [IDTag] // 0x0000000189BBBDB0-0x0000000189BBBDF0
		// [XID] // 0x0000000189BBBDB0-0x0000000189BBBDF0
		public FileGUIDListBase BuildSectionAny(string sectionGuid) => default; // 0x0000000186D2A1E0-0x0000000186D2A410
		// [XID] // 0x000000018978B850-0x000000018978B870
		private void RefreshBuildFilesMapForBuildFileGuidList(Dictionary<string, PBXBuildFileData> mapForTarget, FileGUIDListBase list) {} // 0x0000000186D2D450-0x0000000186D2D680
		// [XID] // 0x00000001897C87D0-0x00000001897C87F0
		private void RefreshMapsForGroupChildren(string projectPath, string realPath, PBXSourceTree realPathTree, PBXGroupData parent) {} // 0x0000000186D2D680-0x0000000186D2DC20
		// [XID] // 0x0000000189BD5630-0x0000000189BD5650
		private void RefreshAuxMaps() {} // 0x0000000186D2CF40-0x0000000186D2D450
		// [XID] // 0x0000000189BDD270-0x0000000189BDD290
		public void Clear() {} // 0x0000000186D2AA10-0x0000000186D2B380
		// [XID] // 0x00000001895E9CE0-0x00000001895E9D00
		private void BuildCommentMapForBuildFiles(GUIDToCommentMap comments, List<string> guids, string sectName) {} // 0x0000000186D27490-0x0000000186D27730
		// [XID] // 0x00000001897DEB20-0x00000001897DEB40
		private GUIDToCommentMap BuildCommentMap() => default; // 0x0000000186D27730-0x0000000186D29BE0
		// [XID] // 0x00000001895F8EA0-0x00000001895F8EC0
		private static PBXElementDict ParseContent(string content) => default; // 0x0000000186D2C650-0x0000000186D2C780
		// [XID] // 0x00000001896001F0-0x0000000189600210
		public void ReadFromStream(TextReader sr) {} // 0x0000000186D2C780-0x0000000186D2CF40
		// [XID] // 0x00000001896078C0-0x00000001896078E0
		public string WriteToString() => default; // 0x0000000186D301E0-0x0000000186D308E0
		// [XID] // 0x000000018960F3B0-0x000000018960F3D0
		private void RepairStructure(List<string> allGuids) {} // 0x0000000186D2FC00-0x0000000186D2FDF0
		// [XID] // 0x0000000189616990-0x00000001896169B0
		private static void RemoveMissingGuidsFromGuidList(GUIDList guidList, Dictionary<string, bool> allGuids) {} // 0x0000000186D2DC20-0x0000000186D2DF60
		private static bool RemoveObjectsFromSection<T>(KnownSectionBase<T> section, Dictionary<string, bool> allGuids, Func<T, bool> checker)
			where T : PBXObjectData, new() => default;
		// [XID] // 0x000000018961E320-0x000000018961E340
		private bool RepairStructureImpl(Dictionary<string, bool> allGuids) => default; // 0x0000000186D2DF60-0x0000000186D2FC00
		// [XID] // 0x0000000189625810-0x0000000189625830
		public PBXGroupData GroupsGetByName(string name) => default; // 0x0000000186D2BF60-0x0000000186D2C220
	}
}
