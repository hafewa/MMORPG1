// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Entity/EntityAttributeEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MMORPG.Common.Proto.Entity {

  /// <summary>Holder for reflection information generated from Entity/EntityAttributeEntry.proto</summary>
  public static partial class EntityAttributeEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for Entity/EntityAttributeEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityAttributeEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbnRpdHkvRW50aXR5QXR0cmlidXRlRW50cnkucHJvdG8SGk1NT1JQRy5D",
            "b21tb24uUHJvdG8uRW50aXR5IpoBChRFbnRpdHlBdHRyaWJ1dGVFbnRyeRJC",
            "CgR0eXBlGAEgASgOMjQuTU1PUlBHLkNvbW1vbi5Qcm90by5FbnRpdHkuRW50",
            "aXR5QXR0cmlidXRlRW50cnlUeXBlEhAKBmludDMyXxgCIAEoBUgAEhAKBmZs",
            "b2F0XxgDIAEoAkgAEhEKB3N0cmluZ18YBCABKAlIAEIHCgV2YWx1ZSJyChtF",
            "bnRpdHlBdHRyaWJ1dGVTeW5jUmVzcG9uc2USEQoJZW50aXR5X2lkGAEgASgF",
            "EkAKBmVudHJ5cxgCIAMoCzIwLk1NT1JQRy5Db21tb24uUHJvdG8uRW50aXR5",
            "LkVudGl0eUF0dHJpYnV0ZUVudHJ5KlIKGEVudGl0eUF0dHJpYnV0ZUVudHJ5",
            "VHlwZRIICgROT05FEAASCQoFTEVWRUwQARIHCgNFWFAQAhIICgRHT0xEEAMS",
            "BgoCSFAQBBIGCgJNUBAFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Entity.EntityAttributeEntry), global::MMORPG.Common.Proto.Entity.EntityAttributeEntry.Parser, new[]{ "Type", "Int32", "Float", "String" }, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Entity.EntityAttributeSyncResponse), global::MMORPG.Common.Proto.Entity.EntityAttributeSyncResponse.Parser, new[]{ "EntityId", "Entrys" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum EntityAttributeEntryType {
    [pbr::OriginalName("NONE")] None = 0,
    [pbr::OriginalName("LEVEL")] Level = 1,
    [pbr::OriginalName("EXP")] Exp = 2,
    [pbr::OriginalName("GOLD")] Gold = 3,
    [pbr::OriginalName("HP")] Hp = 4,
    [pbr::OriginalName("MP")] Mp = 5,
  }

  #endregion

  #region Messages
  public sealed partial class EntityAttributeEntry : pb::IMessage<EntityAttributeEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityAttributeEntry> _parser = new pb::MessageParser<EntityAttributeEntry>(() => new EntityAttributeEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityAttributeEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MMORPG.Common.Proto.Entity.EntityAttributeEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeEntry(EntityAttributeEntry other) : this() {
      type_ = other.type_;
      switch (other.ValueCase) {
        case ValueOneofCase.Int32:
          Int32 = other.Int32;
          break;
        case ValueOneofCase.Float:
          Float = other.Float;
          break;
        case ValueOneofCase.String:
          String = other.String;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeEntry Clone() {
      return new EntityAttributeEntry(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType type_ = global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "int32_" field.</summary>
    public const int Int32FieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Int32 {
      get { return valueCase_ == ValueOneofCase.Int32 ? (int) value_ : 0; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Int32;
      }
    }

    /// <summary>Field number for the "float_" field.</summary>
    public const int FloatFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Float {
      get { return valueCase_ == ValueOneofCase.Float ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Float;
      }
    }

    /// <summary>Field number for the "string_" field.</summary>
    public const int StringFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string String {
      get { return valueCase_ == ValueOneofCase.String ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.String;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      Int32 = 2,
      Float = 3,
      String = 4,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityAttributeEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityAttributeEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Int32 != other.Int32) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Float, other.Float)) return false;
      if (String != other.String) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None) hash ^= Type.GetHashCode();
      if (valueCase_ == ValueOneofCase.Int32) hash ^= Int32.GetHashCode();
      if (valueCase_ == ValueOneofCase.Float) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Float);
      if (valueCase_ == ValueOneofCase.String) hash ^= String.GetHashCode();
      hash ^= (int) valueCase_;
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
      if (Type != global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (valueCase_ == ValueOneofCase.Int32) {
        output.WriteRawTag(16);
        output.WriteInt32(Int32);
      }
      if (valueCase_ == ValueOneofCase.Float) {
        output.WriteRawTag(29);
        output.WriteFloat(Float);
      }
      if (valueCase_ == ValueOneofCase.String) {
        output.WriteRawTag(34);
        output.WriteString(String);
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
      if (Type != global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (valueCase_ == ValueOneofCase.Int32) {
        output.WriteRawTag(16);
        output.WriteInt32(Int32);
      }
      if (valueCase_ == ValueOneofCase.Float) {
        output.WriteRawTag(29);
        output.WriteFloat(Float);
      }
      if (valueCase_ == ValueOneofCase.String) {
        output.WriteRawTag(34);
        output.WriteString(String);
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
      if (Type != global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (valueCase_ == ValueOneofCase.Int32) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Int32);
      }
      if (valueCase_ == ValueOneofCase.Float) {
        size += 1 + 4;
      }
      if (valueCase_ == ValueOneofCase.String) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(String);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityAttributeEntry other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType.None) {
        Type = other.Type;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.Int32:
          Int32 = other.Int32;
          break;
        case ValueOneofCase.Float:
          Float = other.Float;
          break;
        case ValueOneofCase.String:
          String = other.String;
          break;
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
            Type = (global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType) input.ReadEnum();
            break;
          }
          case 16: {
            Int32 = input.ReadInt32();
            break;
          }
          case 29: {
            Float = input.ReadFloat();
            break;
          }
          case 34: {
            String = input.ReadString();
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
            Type = (global::MMORPG.Common.Proto.Entity.EntityAttributeEntryType) input.ReadEnum();
            break;
          }
          case 16: {
            Int32 = input.ReadInt32();
            break;
          }
          case 29: {
            Float = input.ReadFloat();
            break;
          }
          case 34: {
            String = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class EntityAttributeSyncResponse : pb::IMessage<EntityAttributeSyncResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityAttributeSyncResponse> _parser = new pb::MessageParser<EntityAttributeSyncResponse>(() => new EntityAttributeSyncResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityAttributeSyncResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MMORPG.Common.Proto.Entity.EntityAttributeEntryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeSyncResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeSyncResponse(EntityAttributeSyncResponse other) : this() {
      entityId_ = other.entityId_;
      entrys_ = other.entrys_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAttributeSyncResponse Clone() {
      return new EntityAttributeSyncResponse(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private int entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "entrys" field.</summary>
    public const int EntrysFieldNumber = 2;
    private static readonly pb::FieldCodec<global::MMORPG.Common.Proto.Entity.EntityAttributeEntry> _repeated_entrys_codec
        = pb::FieldCodec.ForMessage(18, global::MMORPG.Common.Proto.Entity.EntityAttributeEntry.Parser);
    private readonly pbc::RepeatedField<global::MMORPG.Common.Proto.Entity.EntityAttributeEntry> entrys_ = new pbc::RepeatedField<global::MMORPG.Common.Proto.Entity.EntityAttributeEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MMORPG.Common.Proto.Entity.EntityAttributeEntry> Entrys {
      get { return entrys_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityAttributeSyncResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityAttributeSyncResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if(!entrys_.Equals(other.entrys_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      hash ^= entrys_.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      entrys_.WriteTo(output, _repeated_entrys_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      entrys_.WriteTo(ref output, _repeated_entrys_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityId);
      }
      size += entrys_.CalculateSize(_repeated_entrys_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityAttributeSyncResponse other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      entrys_.Add(other.entrys_);
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
            EntityId = input.ReadInt32();
            break;
          }
          case 18: {
            entrys_.AddEntriesFrom(input, _repeated_entrys_codec);
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
            EntityId = input.ReadInt32();
            break;
          }
          case 18: {
            entrys_.AddEntriesFrom(ref input, _repeated_entrys_codec);
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
