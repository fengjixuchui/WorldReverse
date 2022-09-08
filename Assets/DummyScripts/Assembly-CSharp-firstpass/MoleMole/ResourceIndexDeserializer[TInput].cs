/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class ResourceIndexDeserializer<TInput> // TypeDefIndex: 7545
		where TInput : IResourceIndexInput
	{
		// Fields
		private readonly Dictionary<int, string> _nameHash;
	
		// Properties
		public bool append { get; set; }
		protected Dictionary<int, string> nameHash { get; }
	
		// Constructors
		public ResourceIndexDeserializer() {}
	
		// Methods
		public bool ReadFromFile(ResourceIndex resourceIndex, string indexFilePath, string dependantBundleDirectoryPath, string dependencyBundleDirectoryPath) => default;
		protected abstract TInput OpenInput(string path);
		protected abstract int ReadNameHash(TInput input);
		protected abstract int ReadAssetLocations(TInput input, ResourceIndex resourceIndex, string bundleDirectoryPath);
		protected abstract int ReadPreloadBundles(TInput input, ResourceIndex resourceIndex);
		protected abstract int ReadBlockInfo(TInput input, ResourceIndex resourceIndex);
		protected abstract int ReadBundleDependencyMap(TInput input, ResourceIndex resourceIndex, string dependantBundleDirectoryPath, string dependencyBundleDirectoryPath);
		protected string AppendPathSeperatorIfNecessary(string path) => default;
		protected string ConcatDirectoryWithName(string directoryPath, string bundleName) => default;
		protected string ReadIdentifierWithHash(TInput input) => default;
	}
}
