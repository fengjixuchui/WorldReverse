/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: NativeGallery.Runtime.dll - Assembly: NativeGallery.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6689-6699

public static class NativeGallery // TypeDefIndex: 6690
{
	// Fields
	private const bool PermissionFreeMode = true; // Metadata: 0x00ADDB80

	// Nested types
	public struct ImageProperties // TypeDefIndex: 6691
	{
		// Fields
		public readonly int width; // 0x00
		public readonly int height; // 0x04
		public readonly string mimeType; // 0x08
		public readonly ImageOrientation orientation; // 0x10

		// Constructors
		public ImageProperties(int width, int height, string mimeType, ImageOrientation orientation) {
			this.width = default;
			this.height = default;
			this.mimeType = default;
			this.orientation = default;
		} // 0x000000018954F2D0-0x000000018954F360
	}

	public struct VideoProperties // TypeDefIndex: 6692
	{
		// Fields
		public readonly int width; // 0x00
		public readonly int height; // 0x04
		public readonly long duration; // 0x08
		public readonly float rotation; // 0x10

		// Constructors
		public VideoProperties(int width, int height, long duration, float rotation) {
			this.width = default;
			this.height = default;
			this.duration = default;
			this.rotation = default;
		} // 0x0000000189552510-0x0000000189552520
	}

	public enum PermissionType // TypeDefIndex: 6693
	{
		Read = 0,
		Write = 1
	}

	public enum Permission // TypeDefIndex: 6694
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2
	}

	[Flags] // 0x000000018990A800-0x000000018990A810
	public enum MediaType // TypeDefIndex: 6695
	{
		Image = 1,
		Video = 2,
		Audio = 4
	}

	public enum ImageOrientation // TypeDefIndex: 6696
	{
		Unknown = -1,
		Normal = 0,
		Rotate90 = 1,
		Rotate180 = 2,
		Rotate270 = 3,
		FlipHorizontal = 4,
		Transpose = 5,
		FlipVertical = 6,
		Transverse = 7
	}

	public delegate void MediaSaveCallback(bool success, string path); // TypeDefIndex: 6697; 0x000000018954FC60-0x000000018954FE20

	public delegate void MediaPickCallback(string path); // TypeDefIndex: 6698; 0x000000018954F470-0x000000018954F6D0

	public delegate void MediaPickMultipleCallback(string[] paths); // TypeDefIndex: 6699; 0x000000018954F860-0x000000018954FAC0

	// Methods
	public static Permission CheckPermission(PermissionType permissionType) => default; // 0x000000018954FF90-0x000000018954FFE0
	public static Permission RequestPermission(PermissionType permissionType) => default; // 0x0000000189551790-0x00000001895517E0
	private static void TryExtendLimitedAccessPermission() {} // 0x00000001895523F0-0x0000000189552510
	public static bool CanOpenSettings() => default; // 0x000000018954FEA0-0x000000018954FEF0
	public static void OpenSettings() {} // 0x0000000189551740-0x0000000189551790
	public static Permission SaveImageToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null) => default; // 0x0000000189551BC0-0x0000000189551C70
	public static Permission SaveImageToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null) => default; // 0x0000000189551940-0x00000001895519F0
	public static Permission SaveImageToGallery(Texture2D image, string album, string filename, MediaSaveCallback callback = null) => default; // 0x00000001895519F0-0x0000000189551BC0
	public static Permission SaveVideoToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null) => default; // 0x0000000189552290-0x0000000189552340
	public static Permission SaveVideoToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null) => default; // 0x0000000189552340-0x00000001895523F0
	private static Permission SaveAudioToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null) => default; // 0x00000001895517E0-0x0000000189551890
	private static Permission SaveAudioToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null) => default; // 0x0000000189551890-0x0000000189551940
	public static bool CanSelectMultipleFilesFromGallery() => default; // 0x000000018954FEF0-0x000000018954FF40
	public static bool CanSelectMultipleMediaTypesFromGallery() => default; // 0x000000018954FF40-0x000000018954FF90
	public static Permission GetImageFromGallery(MediaPickCallback callback, string title = "" /* Metadata: 0x00ADDB0A */, string mime = "image/*" /* Metadata: 0x00ADDB0E */) => default; // 0x0000000189550120-0x00000001895501C0
	public static Permission GetVideoFromGallery(MediaPickCallback callback, string title = "" /* Metadata: 0x00ADDB19 */, string mime = "video/*" /* Metadata: 0x00ADDB1D */) => default; // 0x0000000189550EC0-0x0000000189550F60
	public static Permission GetAudioFromGallery(MediaPickCallback callback, string title = "" /* Metadata: 0x00ADDB28 */, string mime = "audio/*" /* Metadata: 0x00ADDB2C */) => default; // 0x000000018954FFE0-0x0000000189550080
	public static Permission GetMixedMediaFromGallery(MediaPickCallback callback, MediaType mediaTypes, string title = "" /* Metadata: 0x00ADDB37 */) => default; // 0x0000000189550670-0x0000000189550710
	public static Permission GetImagesFromGallery(MediaPickMultipleCallback callback, string title = "" /* Metadata: 0x00ADDB3B */, string mime = "image/*" /* Metadata: 0x00ADDB3F */) => default; // 0x00000001895503C0-0x0000000189550460
	public static Permission GetVideosFromGallery(MediaPickMultipleCallback callback, string title = "" /* Metadata: 0x00ADDB4A */, string mime = "video/*" /* Metadata: 0x00ADDB4E */) => default; // 0x0000000189551250-0x00000001895512F0
	public static Permission GetAudiosFromGallery(MediaPickMultipleCallback callback, string title = "" /* Metadata: 0x00ADDB59 */, string mime = "audio/*" /* Metadata: 0x00ADDB5D */) => default; // 0x0000000189550080-0x0000000189550120
	public static Permission GetMixedMediasFromGallery(MediaPickMultipleCallback callback, MediaType mediaTypes, string title = "" /* Metadata: 0x00ADDB68 */) => default; // 0x0000000189550710-0x00000001895507B0
	public static bool IsMediaPickerBusy() => default; // 0x00000001895512F0-0x0000000189551340
	public static MediaType GetMediaTypeOfFile(string path) => default; // 0x0000000189550540-0x0000000189550670
	private static Permission SaveToGallery(byte[] mediaBytes, string album, string filename, MediaType mediaType, MediaSaveCallback callback) => default; // 0x0000000189551CE0-0x0000000189551F50
	private static Permission SaveToGallery(string existingMediaPath, string album, string filename, MediaType mediaType, MediaSaveCallback callback) => default; // 0x0000000189551F50-0x0000000189552290
	private static void SaveToGalleryInternal(string path, string album, MediaType mediaType, MediaSaveCallback callback) {} // 0x0000000189551C70-0x0000000189551CE0
	private static string GetTemporarySavePath(string filename) => default; // 0x00000001895508D0-0x00000001895509A0
	private static Permission GetMediaFromGallery(MediaPickCallback callback, MediaType mediaType, string mime, string title) => default; // 0x0000000189550460-0x0000000189550540
	private static Permission GetMultipleMediaFromGallery(MediaPickMultipleCallback callback, MediaType mediaType, string mime, string title) => default; // 0x00000001895507B0-0x00000001895508D0
	private static byte[] GetTextureBytes(Texture2D texture, bool isJpeg) => default; // 0x0000000189550E10-0x0000000189550EC0
	private static byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg) => default; // 0x00000001895509A0-0x0000000189550E10
	public static Texture2D LoadImageAtPath(string imagePath, int maxSize = -1 /* Metadata: 0x00ADDB6C */, bool markTextureNonReadable = true /* Metadata: 0x00ADDB70 */, bool generateMipmaps = true /* Metadata: 0x00ADDB71 */, bool linearColorSpace = false /* Metadata: 0x00ADDB72 */) => default; // 0x0000000189551340-0x0000000189551740
	public static Texture2D GetVideoThumbnail(string videoPath, int maxSize = -1 /* Metadata: 0x00ADDB73 */, double captureTimeInSeconds = -1 /* Metadata: 0x00ADDB77 */, bool markTextureNonReadable = true /* Metadata: 0x00ADDB7F */) => default; // 0x0000000189551180-0x0000000189551250
	public static ImageProperties GetImageProperties(string imagePath) => default; // 0x00000001895501C0-0x00000001895503C0
	public static VideoProperties GetVideoProperties(string videoPath) => default; // 0x0000000189550F60-0x0000000189551180
}

