// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Base/NetError.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MMORPG.Common.Proto.Base {

  /// <summary>Holder for reflection information generated from Base/NetError.proto</summary>
  public static partial class NetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for Base/NetError.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNCYXNlL05ldEVycm9yLnByb3RvEhhNTU9SUEcuQ29tbW9uLlByb3RvLkJh",
            "c2UqqQIKCE5ldEVycm9yEgsKB1N1Y2Nlc3MQABIPCgtVbmtub3dFcnJvchAB",
            "EhEKDUxvZ2luQ29uZmxpY3QQAhIfChtJbmNvcnJlY3RVc2VybmFtZU9yUGFz",
            "c3dvcmQQAxITCg9JbGxlZ2FsVXNlcm5hbWUQBBIYChRJbGxlZ2FsQ2hhcmFj",
            "dGVyTmFtZRAFEhIKDlJlcGVhdFVzZXJuYW1lEAYSFwoTUmVwZWF0Q2hhcmFj",
            "dGVyTmFtZRAHEhQKEEludmFsaWRDaGFyYWN0ZXIQCBIOCgpJbnZhbGlkTWFw",
            "EAkSIQodQ2hhcmFjdGVyQ3JlYXRpb25MaW1pdFJlYWNoZWQQChIOCgpPdXRP",
            "ZlJhbmdlEAsSFgoSRW50aXR5RG9lc05vdEV4aXN0EAxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MMORPG.Common.Proto.Base.NetError), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum NetError {
    [pbr::OriginalName("Success")] Success = 0,
    [pbr::OriginalName("UnknowError")] UnknowError = 1,
    [pbr::OriginalName("LoginConflict")] LoginConflict = 2,
    [pbr::OriginalName("IncorrectUsernameOrPassword")] IncorrectUsernameOrPassword = 3,
    [pbr::OriginalName("IllegalUsername")] IllegalUsername = 4,
    [pbr::OriginalName("IllegalCharacterName")] IllegalCharacterName = 5,
    [pbr::OriginalName("RepeatUsername")] RepeatUsername = 6,
    [pbr::OriginalName("RepeatCharacterName")] RepeatCharacterName = 7,
    [pbr::OriginalName("InvalidCharacter")] InvalidCharacter = 8,
    [pbr::OriginalName("InvalidMap")] InvalidMap = 9,
    [pbr::OriginalName("CharacterCreationLimitReached")] CharacterCreationLimitReached = 10,
    [pbr::OriginalName("OutOfRange")] OutOfRange = 11,
    [pbr::OriginalName("EntityDoesNotExist")] EntityDoesNotExist = 12,
  }

  #endregion

}

#endregion Designer generated code
