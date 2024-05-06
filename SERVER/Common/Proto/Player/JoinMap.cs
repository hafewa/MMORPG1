// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Player/JoinMap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Player {

  /// <summary>Holder for reflection information generated from Player/JoinMap.proto</summary>
  public static partial class JoinMapReflection {

    #region Descriptor
    /// <summary>File descriptor for Player/JoinMap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JoinMapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQbGF5ZXIvSm9pbk1hcC5wcm90bxITQ29tbW9uLlByb3RvLlBsYXllchoT",
            "QmFzZS9OZXRFcnJvci5wcm90bxoZRW50aXR5L05ldFRyYW5zZm9ybS5wcm90",
            "byImCg5Kb2luTWFwUmVxdWVzdBIUCgxjaGFyYWN0ZXJfaWQYASABKAUilgEK",
            "D0pvaW5NYXBSZXNwb25zZRIqCgVlcnJvchgBIAEoDjIbLkNvbW1vbi5Qcm90",
            "by5CYXNlLk5ldEVycm9yEhEKCWVudGl0eV9pZBgCIAEoBRIOCgZtYXBfaWQY",
            "AyABKAUSNAoJdHJhbnNmb3JtGAQgASgLMiEuQ29tbW9uLlByb3RvLkVudGl0",
            "eS5OZXRUcmFuc2Zvcm1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.Proto.Base.NetErrorReflection.Descriptor, global::Common.Proto.Entity.NetTransformReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Player.JoinMapRequest), global::Common.Proto.Player.JoinMapRequest.Parser, new[]{ "CharacterId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Player.JoinMapResponse), global::Common.Proto.Player.JoinMapResponse.Parser, new[]{ "Error", "EntityId", "MapId", "Transform" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class JoinMapRequest : pb::IMessage<JoinMapRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JoinMapRequest> _parser = new pb::MessageParser<JoinMapRequest>(() => new JoinMapRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JoinMapRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Player.JoinMapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapRequest(JoinMapRequest other) : this() {
      characterId_ = other.characterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapRequest Clone() {
      return new JoinMapRequest(this);
    }

    /// <summary>Field number for the "character_id" field.</summary>
    public const int CharacterIdFieldNumber = 1;
    private int characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JoinMapRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JoinMapRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CharacterId != other.CharacterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CharacterId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CharacterId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CharacterId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CharacterId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CharacterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CharacterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JoinMapRequest other) {
      if (other == null) {
        return;
      }
      if (other.CharacterId != 0) {
        CharacterId = other.CharacterId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CharacterId = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            CharacterId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class JoinMapResponse : pb::IMessage<JoinMapResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JoinMapResponse> _parser = new pb::MessageParser<JoinMapResponse>(() => new JoinMapResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JoinMapResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Player.JoinMapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapResponse(JoinMapResponse other) : this() {
      error_ = other.error_;
      entityId_ = other.entityId_;
      mapId_ = other.mapId_;
      transform_ = other.transform_ != null ? other.transform_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinMapResponse Clone() {
      return new JoinMapResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::Common.Proto.Base.NetError error_ = global::Common.Proto.Base.NetError.Success;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Base.NetError Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
    private int entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 3;
    private int mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 4;
    private global::Common.Proto.Entity.NetTransform transform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Entity.NetTransform Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JoinMapResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JoinMapResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      if (EntityId != other.EntityId) return false;
      if (MapId != other.MapId) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != global::Common.Proto.Base.NetError.Success) hash ^= Error.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Error != global::Common.Proto.Base.NetError.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Error);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(EntityId);
      }
      if (MapId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MapId);
      }
      if (transform_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Error != global::Common.Proto.Base.NetError.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Error);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(EntityId);
      }
      if (MapId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MapId);
      }
      if (transform_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Error != global::Common.Proto.Base.NetError.Success) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Error);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityId);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapId);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JoinMapResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error != global::Common.Proto.Base.NetError.Success) {
        Error = other.Error;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          Transform = new global::Common.Proto.Entity.NetTransform();
        }
        Transform.MergeFrom(other.Transform);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Error = (global::Common.Proto.Base.NetError) input.ReadEnum();
            break;
          }
          case 16: {
            EntityId = input.ReadInt32();
            break;
          }
          case 24: {
            MapId = input.ReadInt32();
            break;
          }
          case 34: {
            if (transform_ == null) {
              Transform = new global::Common.Proto.Entity.NetTransform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Error = (global::Common.Proto.Base.NetError) input.ReadEnum();
            break;
          }
          case 16: {
            EntityId = input.ReadInt32();
            break;
          }
          case 24: {
            MapId = input.ReadInt32();
            break;
          }
          case 34: {
            if (transform_ == null) {
              Transform = new global::Common.Proto.Entity.NetTransform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
