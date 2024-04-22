// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Player/NetCharacter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Player {

  /// <summary>Holder for reflection information generated from Player/NetCharacter.proto</summary>
  public static partial class NetCharacterReflection {

    #region Descriptor
    /// <summary>File descriptor for Player/NetCharacter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetCharacterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQbGF5ZXIvTmV0Q2hhcmFjdGVyLnByb3RvEhNDb21tb24uUHJvdG8uUGxh",
            "eWVyGhZFbnRpdHkvTmV0RW50aXR5LnByb3RvIsYBCgxOZXRDaGFyYWN0ZXIS",
            "LgoGZW50aXR5GAEgASgLMh4uQ29tbW9uLlByb3RvLkVudGl0eS5OZXRFbnRp",
            "dHkSDAoEbmFtZRgCIAEoCRIQCghzcGFjZV9pZBgDIAEoBRINCgVsZXZlbBgE",
            "IAEoBRIUCgxjaGFyYWN0ZXJfaWQYBSABKAUSDgoGam9iX2lkGAYgASgFEgsK",
            "A2V4cBgHIAEoAxIMCgRnb2xkGAggASgDEgoKAmhwGAkgASgFEgoKAm1wGAog",
            "ASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.Proto.Entity.NetEntityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Player.NetCharacter), global::Common.Proto.Player.NetCharacter.Parser, new[]{ "Entity", "Name", "SpaceId", "Level", "CharacterId", "JobId", "Exp", "Gold", "Hp", "Mp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NetCharacter : pb::IMessage<NetCharacter>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NetCharacter> _parser = new pb::MessageParser<NetCharacter>(() => new NetCharacter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NetCharacter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Player.NetCharacterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetCharacter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetCharacter(NetCharacter other) : this() {
      entity_ = other.entity_ != null ? other.entity_.Clone() : null;
      name_ = other.name_;
      spaceId_ = other.spaceId_;
      level_ = other.level_;
      characterId_ = other.characterId_;
      jobId_ = other.jobId_;
      exp_ = other.exp_;
      gold_ = other.gold_;
      hp_ = other.hp_;
      mp_ = other.mp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetCharacter Clone() {
      return new NetCharacter(this);
    }

    /// <summary>Field number for the "entity" field.</summary>
    public const int EntityFieldNumber = 1;
    private global::Common.Proto.Entity.NetEntity entity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Entity.NetEntity Entity {
      get { return entity_; }
      set {
        entity_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "space_id" field.</summary>
    public const int SpaceIdFieldNumber = 3;
    private int spaceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SpaceId {
      get { return spaceId_; }
      set {
        spaceId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 4;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "character_id" field.</summary>
    public const int CharacterIdFieldNumber = 5;
    private int characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    /// <summary>Field number for the "job_id" field.</summary>
    public const int JobIdFieldNumber = 6;
    private int jobId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int JobId {
      get { return jobId_; }
      set {
        jobId_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 7;
    private long exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "gold" field.</summary>
    public const int GoldFieldNumber = 8;
    private long gold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Gold {
      get { return gold_; }
      set {
        gold_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 9;
    private int hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "mp" field.</summary>
    public const int MpFieldNumber = 10;
    private int mp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Mp {
      get { return mp_; }
      set {
        mp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NetCharacter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NetCharacter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Entity, other.Entity)) return false;
      if (Name != other.Name) return false;
      if (SpaceId != other.SpaceId) return false;
      if (Level != other.Level) return false;
      if (CharacterId != other.CharacterId) return false;
      if (JobId != other.JobId) return false;
      if (Exp != other.Exp) return false;
      if (Gold != other.Gold) return false;
      if (Hp != other.Hp) return false;
      if (Mp != other.Mp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (entity_ != null) hash ^= Entity.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (SpaceId != 0) hash ^= SpaceId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
      if (JobId != 0) hash ^= JobId.GetHashCode();
      if (Exp != 0L) hash ^= Exp.GetHashCode();
      if (Gold != 0L) hash ^= Gold.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (Mp != 0) hash ^= Mp.GetHashCode();
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
      if (entity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Entity);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (SpaceId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SpaceId);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Level);
      }
      if (CharacterId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CharacterId);
      }
      if (JobId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(JobId);
      }
      if (Exp != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Exp);
      }
      if (Gold != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Gold);
      }
      if (Hp != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Mp);
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
      if (entity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Entity);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (SpaceId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SpaceId);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Level);
      }
      if (CharacterId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CharacterId);
      }
      if (JobId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(JobId);
      }
      if (Exp != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Exp);
      }
      if (Gold != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Gold);
      }
      if (Hp != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Mp);
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
      if (entity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Entity);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (SpaceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpaceId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (CharacterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CharacterId);
      }
      if (JobId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(JobId);
      }
      if (Exp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Exp);
      }
      if (Gold != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Gold);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hp);
      }
      if (Mp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NetCharacter other) {
      if (other == null) {
        return;
      }
      if (other.entity_ != null) {
        if (entity_ == null) {
          Entity = new global::Common.Proto.Entity.NetEntity();
        }
        Entity.MergeFrom(other.Entity);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.SpaceId != 0) {
        SpaceId = other.SpaceId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.CharacterId != 0) {
        CharacterId = other.CharacterId;
      }
      if (other.JobId != 0) {
        JobId = other.JobId;
      }
      if (other.Exp != 0L) {
        Exp = other.Exp;
      }
      if (other.Gold != 0L) {
        Gold = other.Gold;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.Mp != 0) {
        Mp = other.Mp;
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
          case 10: {
            if (entity_ == null) {
              Entity = new global::Common.Proto.Entity.NetEntity();
            }
            input.ReadMessage(Entity);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            SpaceId = input.ReadInt32();
            break;
          }
          case 32: {
            Level = input.ReadInt32();
            break;
          }
          case 40: {
            CharacterId = input.ReadInt32();
            break;
          }
          case 48: {
            JobId = input.ReadInt32();
            break;
          }
          case 56: {
            Exp = input.ReadInt64();
            break;
          }
          case 64: {
            Gold = input.ReadInt64();
            break;
          }
          case 72: {
            Hp = input.ReadInt32();
            break;
          }
          case 80: {
            Mp = input.ReadInt32();
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
          case 10: {
            if (entity_ == null) {
              Entity = new global::Common.Proto.Entity.NetEntity();
            }
            input.ReadMessage(Entity);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            SpaceId = input.ReadInt32();
            break;
          }
          case 32: {
            Level = input.ReadInt32();
            break;
          }
          case 40: {
            CharacterId = input.ReadInt32();
            break;
          }
          case 48: {
            JobId = input.ReadInt32();
            break;
          }
          case 56: {
            Exp = input.ReadInt64();
            break;
          }
          case 64: {
            Gold = input.ReadInt64();
            break;
          }
          case 72: {
            Hp = input.ReadInt32();
            break;
          }
          case 80: {
            Mp = input.ReadInt32();
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
