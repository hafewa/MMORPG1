// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Entity/ActorState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Monster {

  /// <summary>Holder for reflection information generated from Entity/ActorState.proto</summary>
  public static partial class ActorStateReflection {

    #region Descriptor
    /// <summary>File descriptor for Entity/ActorState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActorStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFbnRpdHkvQWN0b3JTdGF0ZS5wcm90bxIUQ29tbW9uLlByb3RvLk1vbnN0",
            "ZXIqNwoKQWN0b3JTdGF0ZRIICgRJRExFEAASCAoETU9WRRABEgkKBVNLSUxM",
            "EAISCgoGREFNQUdFEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Common.Proto.Monster.ActorState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ActorState {
    [pbr::OriginalName("IDLE")] Idle = 0,
    [pbr::OriginalName("MOVE")] Move = 1,
    [pbr::OriginalName("SKILL")] Skill = 2,
    [pbr::OriginalName("DAMAGE")] Damage = 3,
  }

  #endregion

}

#endregion Designer generated code