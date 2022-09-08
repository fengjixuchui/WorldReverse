/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AssetLoadJob<T> : AssetLoadJob // TypeDefIndex: 7355
		where T : UnityEngine.Object
	{
		// Fields
		private uint _handle;
		private ILoadedResourceReceiver<T> _receiver;
		private bool _allBundlesLoaded;
		private bool _shallDropAsset;
		private List<int> _loadedBundles;
		private BundleLoadResult _bundleFailResult;
		private uint _assetRequest;
	
		// Properties
		protected Queue<BundleLoadResultReceiver> _dependencyBundles { get; private set; }
	
		// Nested types
		public class Spawner : ISpawner<AssetLoadJob<T>, ResourceIdentifier, uint, ILoadedResourceReceiver<T>> // TypeDefIndex: 7356
		{
			// Constructors
			public Spawner() {}
	
			// Methods
			public AssetLoadJob<T> Spawn(ResourceIdentifier param1, uint param2, ILoadedResourceReceiver<T> param3) => default;
		}
	
		public class Polisher : IPolisher<AssetLoadJob<T>, ResourceIdentifier, uint, ILoadedResourceReceiver<T>> // TypeDefIndex: 7357
		{
			// Constructors
			public Polisher() {}
	
			// Methods
			public void Polish(AssetLoadJob<T> reused, ResourceIdentifier param1, uint param2, ILoadedResourceReceiver<T> param3) {}
		}
	
		// Constructors
		public AssetLoadJob() {} // Dummy constructor
		private AssetLoadJob(ResourceIdentifier request, uint handle, ILoadedResourceReceiver<T> receiver) {}
	
		// Methods
		public override void Start() {}
		private void SyncLoad() {}
		public override void Abort(bool byUser) {}
		public override void Tick() {}
		public override void Recycle() {}
		public override void BeforeRecycle() {}
		private void LoadBundle(int bundlePath) {}
		private void QuickFailAborted() {}
		private void QuickFinishWithLoaded() {}
		public override ResourceJob PrevJob() => default;
		private void TickWaitForBundles() {}
		private void FailWithBundleResult(BundleLoadResult result) {}
		private void DecreaseLoadedBundleUsageCounts() {}
	}
}
