/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKPopImageManager // TypeDefIndex: 8688
	{
		// Fields
		public static readonly MiHoYoSDKPopImageManager Instacne; // 0x00
		private const string PopImageShowDateCacheKey = "MIHOYOSDK_ALERT_PIC_SHOW_DATE_CACHE_"; // Metadata: 0x00AE1FB5
		private string CachePath; // 0x10
		private List<MiHoYoSDKPopImageModel> popImageList; // 0x18
		private List<PopImageDateModel> cacheShowImageList; // 0x20
	
		// Nested types
		[Serializable]
		private class PopImageDateModel // TypeDefIndex: 8689
		{
			// Fields
			public int id; // 0x10
			public PopImageType mode; // 0x14
			public int days; // 0x18
	
			// Constructors
			public PopImageDateModel() {} // 0x000000018626BF10-0x000000018626BF70
		}
	
		// Constructors
		public MiHoYoSDKPopImageManager() {} // 0x00000001862613C0-0x00000001862614B0
		static MiHoYoSDKPopImageManager() {} // 0x0000000186261340-0x00000001862613C0
	
		// Methods
		// [XID] // 0x00000001898A6480-0x00000001898A64A0
		public bool Show() => default; // 0x00000001862611A0-0x0000000186261340
		// [XID] // 0x00000001897859E0-0x0000000189785A00
		private void OnClickImage(MiHoYoSDKPopImageModel model) {} // 0x00000001862606F0-0x0000000186260840
		// [XID] // 0x0000000189B4FE80-0x0000000189B4FEA0
		private void OnClose(MiHoYoSDKPopImageModel model) {} // 0x0000000186260840-0x0000000186260920
		// [XID] // 0x0000000189B66640-0x0000000189B66660
		private void SendCloseNotification() {} // 0x00000001862610E0-0x00000001862611A0
		// [XID] // 0x000000018979C870-0x000000018979C890
		private bool CheckPopImage() => default; // 0x000000018625E900-0x000000018625EA20
		// [XID] // 0x00000001897A3CB0-0x00000001897A3CD0
		private MiHoYoSDKPopImageModel GetPopImageModel() => default; // 0x000000018625F4D0-0x000000018625F670
		// [XID] // 0x00000001898F2620-0x00000001898F2640
		public void ClearList() {} // 0x000000018625EA20-0x000000018625EBF0
		// [XID] // 0x00000001897B2EA0-0x00000001897B2EC0
		public void GetPopImageList() {} // 0x000000018625F310-0x000000018625F4D0
		// [XID] // 0x0000000189A0CA30-0x0000000189A0CA50
		private void OnGetPopImageList(NetworkResponseModel response) {} // 0x00000001862609D0-0x0000000186260CB0
		// [XID] // 0x0000000189678E40-0x0000000189678E60
		private bool IsImageNeedShow(MiHoYoSDKPopImageModel model) => default; // 0x0000000186260020-0x0000000186260250
		// [XID] // 0x0000000189B502F0-0x0000000189B50310
		private void SaveCacheShowImageList() {} // 0x0000000186260CB0-0x0000000186260DE0
		// [XID] // 0x00000001897D1540-0x00000001897D1560
		private void GetCacheShowImageList() {} // 0x000000018625F060-0x000000018625F230
		// [XID] // 0x00000001897D9400-0x00000001897D9420
		private string GetPopImageShowDateCacheKey() => default; // 0x000000018625F670-0x000000018625F9B0
		// [XID] // 0x0000000189B6DBE0-0x0000000189B6DC00
		public void ConsumePopImage(int picId) {} // 0x000000018625EBF0-0x000000018625EE00
		// [XID] // 0x00000001897E7E10-0x00000001897E7E30
		private void OnConsumePopImage(NetworkResponseModel response) {} // 0x0000000186260920-0x00000001862609D0
		// [XID] // 0x0000000189B5F450-0x0000000189B5F470
		private void SaveConsumePopImage(MiHoYoSDKPopImageModel model) {} // 0x0000000186260DE0-0x00000001862610E0
		// [XID] // 0x00000001895E5780-0x00000001895E57A0
		private JSONObject GetQueryMap() => default; // 0x000000018625F9B0-0x0000000186260020
		// [XID] // 0x0000000189850AF0-0x0000000189850B10
		public void DownLoad(string url, UnityAction<Texture2D> callback) {} // 0x000000018625EE00-0x000000018625EF20
		// [XID] // 0x0000000189805EC0-0x0000000189805EE0
		private string GetFileName(string url) => default; // 0x000000018625F230-0x000000018625F310
		// [XID] // 0x00000001897BBA90-0x00000001897BBAB0
		private bool FileExists(string url) => default; // 0x000000018625EF20-0x000000018625F060
		[DebuggerHidden] // 0x0000000189814D70-0x0000000189814DB0
		// [XID] // 0x0000000189814D70-0x0000000189814DB0
		private IEnumerator LoadTexture(string url, UnityAction<Texture2D> callback) => default; // 0x00000001862604D0-0x0000000186260610
		[DebuggerHidden] // 0x000000018981F8F0-0x000000018981F930
		// [XID] // 0x000000018981F8F0-0x000000018981F930
		private IEnumerator LoadLocalTexture(string url, UnityAction<Texture2D> callback) => default; // 0x0000000186260250-0x0000000186260390
		[DebuggerHidden] // 0x0000000189829DF0-0x0000000189829E30
		// [XID] // 0x0000000189829DF0-0x0000000189829E30
		private IEnumerator LoadNetworkTexture(string url, UnityAction<Texture2D> callback) => default; // 0x0000000186260390-0x00000001862604D0
		// [XID] // 0x0000000189A69270-0x0000000189A69290
		private void OnCallback(UnityAction<Texture2D> callback, Texture2D data = null) {} // 0x0000000186260610-0x00000001862606F0
	}
}
