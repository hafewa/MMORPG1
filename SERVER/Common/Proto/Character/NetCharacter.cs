// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Character/NetCharacter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Character {

  /// <summary>Holder for reflection information generated from Character/NetCharacter.proto</summary>
  public static partial class NetCharacterReflection {

    #region Descriptor
    /// <summary>File descriptor for Character/NetCharacter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetCharacterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaGFyYWN0ZXIvTmV0Q2hhcmFjdGVyLnByb3RvEhZDb21tb24uUHJvdG8u",
            "Q2hhcmFjdGVyIpUBCgxOZXRDaGFyYWN0ZXISFAoMY2hhcmFjdGVyX2lkGAEg",
            "ASgDEg8KB3VuaXRfaWQYAiABKAUSDAoEbmFtZRgDIAEoCRIOCgZtYXBfaWQY",
            "BCABKAUSDQoFbGV2ZWwYBSABKAUSCwoDZXhwGAYgASgDEgwKBGdvbGQYByAB",
            "KAMSCgoCaHAYCCABKAUSCgoCbXAYCSABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Character.NetCharacter), global::Common.Proto.Character.NetCharacter.Parser, new[]{ "CharacterId", "UnitId", "Name", "MapId", "Level", "Exp", "Gold", "Hp", "Mp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
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
      get { return global::Common.Proto.Character.NetCharacterReflection.Descriptor.MessageTypes[0]; }
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
      characterId_ = other.characterId_;
      unitId_ = other.unitId_;
      name_ = other.name_;
      mapId_ = other.mapId_;
      level_ = other.level_;
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

    /// <summary>Field number for the "character_id" field.</summary>
    public const int CharacterIdFieldNumber = 1;
    private long characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    /// <summary>Field number for the "unit_id" field.</summary>
    public const int UnitIdFieldNumber = 2;
    private int unitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int UnitId {
      get { return unitId_; }
      set {
        unitId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 4;
    private int mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 6;
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
    public const int GoldFieldNumber = 7;
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
    public const int HpFieldNumber = 8;
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
    public const int MpFieldNumber = 9;
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
      if (CharacterId != other.CharacterId) return false;
      if (UnitId != other.UnitId) return false;
      if (Name != other.Name) return false;
      if (MapId != other.MapId) return false;
      if (Level != other.Level) return false;
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
      if (CharacterId != 0L) hash ^= CharacterId.GetHashCode();
      if (UnitId != 0) hash ^= UnitId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
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
      if (CharacterId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CharacterId);
      }
      if (UnitId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UnitId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MapId);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Level);
      }
      if (Exp != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Exp);
      }
      if (Gold != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Gold);
      }
      if (Hp != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(72);
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
      if (CharacterId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CharacterId);
      }
      if (UnitId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UnitId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MapId);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Level);
      }
      if (Exp != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Exp);
      }
      if (Gold != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Gold);
      }
      if (Hp != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(72);
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
      if (CharacterId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CharacterId);
      }
      if (UnitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnitId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
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
      if (other.CharacterId != 0L) {
        CharacterId = other.CharacterId;
      }
      if (other.UnitId != 0) {
        UnitId = other.UnitId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.Level != 0) {
        Level = other.Level;
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
          case 8: {
            CharacterId = input.ReadInt64();
            break;
          }
          case 16: {
            UnitId = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            MapId = input.ReadInt32();
            break;
          }
          case 40: {
            Level = input.ReadInt32();
            break;
          }
          case 48: {
            Exp = input.ReadInt64();
            break;
          }
          case 56: {
            Gold = input.ReadInt64();
            break;
          }
          case 64: {
            Hp = input.ReadInt32();
            break;
          }
          case 72: {
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
          case 8: {
            CharacterId = input.ReadInt64();
            break;
          }
          case 16: {
            UnitId = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            MapId = input.ReadInt32();
            break;
          }
          case 40: {
            Level = input.ReadInt32();
            break;
          }
          case 48: {
            Exp = input.ReadInt64();
            break;
          }
          case 56: {
            Gold = input.ReadInt64();
            break;
          }
          case 64: {
            Hp = input.ReadInt32();
            break;
          }
          case 72: {
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
