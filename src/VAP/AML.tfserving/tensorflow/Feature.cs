// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/example/feature.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/example/feature.proto</summary>
  public static partial class FeatureReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/example/feature.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV0ZW5zb3JmbG93L2NvcmUvZXhhbXBsZS9mZWF0dXJlLnByb3RvEgp0ZW5z",
            "b3JmbG93IhoKCUJ5dGVzTGlzdBINCgV2YWx1ZRgBIAMoDCIeCglGbG9hdExp",
            "c3QSEQoFdmFsdWUYASADKAJCAhABIh4KCUludDY0TGlzdBIRCgV2YWx1ZRgB",
            "IAMoA0ICEAEimAEKB0ZlYXR1cmUSKwoKYnl0ZXNfbGlzdBgBIAEoCzIVLnRl",
            "bnNvcmZsb3cuQnl0ZXNMaXN0SAASKwoKZmxvYXRfbGlzdBgCIAEoCzIVLnRl",
            "bnNvcmZsb3cuRmxvYXRMaXN0SAASKwoKaW50NjRfbGlzdBgDIAEoCzIVLnRl",
            "bnNvcmZsb3cuSW50NjRMaXN0SABCBgoEa2luZCKDAQoIRmVhdHVyZXMSMgoH",
            "ZmVhdHVyZRgBIAMoCzIhLnRlbnNvcmZsb3cuRmVhdHVyZXMuRmVhdHVyZUVu",
            "dHJ5GkMKDEZlYXR1cmVFbnRyeRILCgNrZXkYASABKAkSIgoFdmFsdWUYAiAB",
            "KAsyEy50ZW5zb3JmbG93LkZlYXR1cmU6AjgBIjMKC0ZlYXR1cmVMaXN0EiQK",
            "B2ZlYXR1cmUYASADKAsyEy50ZW5zb3JmbG93LkZlYXR1cmUinAEKDEZlYXR1",
            "cmVMaXN0cxI/CgxmZWF0dXJlX2xpc3QYASADKAsyKS50ZW5zb3JmbG93LkZl",
            "YXR1cmVMaXN0cy5GZWF0dXJlTGlzdEVudHJ5GksKEEZlYXR1cmVMaXN0RW50",
            "cnkSCwoDa2V5GAEgASgJEiYKBXZhbHVlGAIgASgLMhcudGVuc29yZmxvdy5G",
            "ZWF0dXJlTGlzdDoCOAFCLAoWb3JnLnRlbnNvcmZsb3cuZXhhbXBsZUINRmVh",
            "dHVyZVByb3Rvc1AB+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.BytesList), global::Tensorflow.BytesList.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FloatList), global::Tensorflow.FloatList.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Int64List), global::Tensorflow.Int64List.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Feature), global::Tensorflow.Feature.Parser, new[]{ "BytesList", "FloatList", "Int64List" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Features), global::Tensorflow.Features.Parser, new[]{ "Feature" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FeatureList), global::Tensorflow.FeatureList.Parser, new[]{ "Feature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FeatureLists), global::Tensorflow.FeatureLists.Parser, new[]{ "FeatureList" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Containers to hold repeated fundamental values.
  /// </summary>
  public sealed partial class BytesList : pb::IMessage<BytesList> {
    private static readonly pb::MessageParser<BytesList> _parser = new pb::MessageParser<BytesList>(() => new BytesList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BytesList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesList(BytesList other) : this() {
      value_ = other.value_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BytesList Clone() {
      return new BytesList(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_value_codec
        = pb::FieldCodec.ForBytes(10);
    private readonly pbc::RepeatedField<pb::ByteString> value_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> Value {
      get { return value_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BytesList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BytesList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!value_.Equals(other.value_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= value_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      value_.WriteTo(output, _repeated_value_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += value_.CalculateSize(_repeated_value_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BytesList other) {
      if (other == null) {
        return;
      }
      value_.Add(other.value_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            value_.AddEntriesFrom(input, _repeated_value_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class FloatList : pb::IMessage<FloatList> {
    private static readonly pb::MessageParser<FloatList> _parser = new pb::MessageParser<FloatList>(() => new FloatList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FloatList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatList(FloatList other) : this() {
      value_ = other.value_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FloatList Clone() {
      return new FloatList(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_value_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> value_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Value {
      get { return value_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FloatList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FloatList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!value_.Equals(other.value_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= value_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      value_.WriteTo(output, _repeated_value_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += value_.CalculateSize(_repeated_value_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FloatList other) {
      if (other == null) {
        return;
      }
      value_.Add(other.value_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 13: {
            value_.AddEntriesFrom(input, _repeated_value_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Int64List : pb::IMessage<Int64List> {
    private static readonly pb::MessageParser<Int64List> _parser = new pb::MessageParser<Int64List>(() => new Int64List());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Int64List> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64List() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64List(Int64List other) : this() {
      value_ = other.value_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64List Clone() {
      return new Int64List(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private static readonly pb::FieldCodec<long> _repeated_value_codec
        = pb::FieldCodec.ForInt64(10);
    private readonly pbc::RepeatedField<long> value_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> Value {
      get { return value_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Int64List);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Int64List other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!value_.Equals(other.value_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= value_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      value_.WriteTo(output, _repeated_value_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += value_.CalculateSize(_repeated_value_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Int64List other) {
      if (other == null) {
        return;
      }
      value_.Add(other.value_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            value_.AddEntriesFrom(input, _repeated_value_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Containers for non-sequential data.
  /// </summary>
  public sealed partial class Feature : pb::IMessage<Feature> {
    private static readonly pb::MessageParser<Feature> _parser = new pb::MessageParser<Feature>(() => new Feature());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Feature> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature(Feature other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.BytesList:
          BytesList = other.BytesList.Clone();
          break;
        case KindOneofCase.FloatList:
          FloatList = other.FloatList.Clone();
          break;
        case KindOneofCase.Int64List:
          Int64List = other.Int64List.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature Clone() {
      return new Feature(this);
    }

    /// <summary>Field number for the "bytes_list" field.</summary>
    public const int BytesListFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.BytesList BytesList {
      get { return kindCase_ == KindOneofCase.BytesList ? (global::Tensorflow.BytesList) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.BytesList;
      }
    }

    /// <summary>Field number for the "float_list" field.</summary>
    public const int FloatListFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.FloatList FloatList {
      get { return kindCase_ == KindOneofCase.FloatList ? (global::Tensorflow.FloatList) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.FloatList;
      }
    }

    /// <summary>Field number for the "int64_list" field.</summary>
    public const int Int64ListFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Int64List Int64List {
      get { return kindCase_ == KindOneofCase.Int64List ? (global::Tensorflow.Int64List) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.Int64List;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      BytesList = 1,
      FloatList = 2,
      Int64List = 3,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Feature);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Feature other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BytesList, other.BytesList)) return false;
      if (!object.Equals(FloatList, other.FloatList)) return false;
      if (!object.Equals(Int64List, other.Int64List)) return false;
      if (KindCase != other.KindCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.BytesList) hash ^= BytesList.GetHashCode();
      if (kindCase_ == KindOneofCase.FloatList) hash ^= FloatList.GetHashCode();
      if (kindCase_ == KindOneofCase.Int64List) hash ^= Int64List.GetHashCode();
      hash ^= (int) kindCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (kindCase_ == KindOneofCase.BytesList) {
        output.WriteRawTag(10);
        output.WriteMessage(BytesList);
      }
      if (kindCase_ == KindOneofCase.FloatList) {
        output.WriteRawTag(18);
        output.WriteMessage(FloatList);
      }
      if (kindCase_ == KindOneofCase.Int64List) {
        output.WriteRawTag(26);
        output.WriteMessage(Int64List);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.BytesList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BytesList);
      }
      if (kindCase_ == KindOneofCase.FloatList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FloatList);
      }
      if (kindCase_ == KindOneofCase.Int64List) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Int64List);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Feature other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.BytesList:
          BytesList = other.BytesList;
          break;
        case KindOneofCase.FloatList:
          FloatList = other.FloatList;
          break;
        case KindOneofCase.Int64List:
          Int64List = other.Int64List;
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            global::Tensorflow.BytesList subBuilder = new global::Tensorflow.BytesList();
            if (kindCase_ == KindOneofCase.BytesList) {
              subBuilder.MergeFrom(BytesList);
            }
            input.ReadMessage(subBuilder);
            BytesList = subBuilder;
            break;
          }
          case 18: {
            global::Tensorflow.FloatList subBuilder = new global::Tensorflow.FloatList();
            if (kindCase_ == KindOneofCase.FloatList) {
              subBuilder.MergeFrom(FloatList);
            }
            input.ReadMessage(subBuilder);
            FloatList = subBuilder;
            break;
          }
          case 26: {
            global::Tensorflow.Int64List subBuilder = new global::Tensorflow.Int64List();
            if (kindCase_ == KindOneofCase.Int64List) {
              subBuilder.MergeFrom(Int64List);
            }
            input.ReadMessage(subBuilder);
            Int64List = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class Features : pb::IMessage<Features> {
    private static readonly pb::MessageParser<Features> _parser = new pb::MessageParser<Features>(() => new Features());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Features> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Features() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Features(Features other) : this() {
      feature_ = other.feature_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Features Clone() {
      return new Features(this);
    }

    /// <summary>Field number for the "feature" field.</summary>
    public const int FeatureFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Tensorflow.Feature>.Codec _map_feature_codec
        = new pbc::MapField<string, global::Tensorflow.Feature>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.Feature.Parser), 10);
    private readonly pbc::MapField<string, global::Tensorflow.Feature> feature_ = new pbc::MapField<string, global::Tensorflow.Feature>();
    /// <summary>
    /// Map from feature name to feature.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.Feature> Feature {
      get { return feature_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Features);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Features other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Feature.Equals(other.Feature)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Feature.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      feature_.WriteTo(output, _map_feature_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += feature_.CalculateSize(_map_feature_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Features other) {
      if (other == null) {
        return;
      }
      feature_.Add(other.feature_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            feature_.AddEntriesFrom(input, _map_feature_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Containers for sequential data.
  ///
  /// A FeatureList contains lists of Features.  These may hold zero or more
  /// Feature values.
  ///
  /// FeatureLists are organized into categories by name.  The FeatureLists message
  /// contains the mapping from name to FeatureList.
  /// </summary>
  public sealed partial class FeatureList : pb::IMessage<FeatureList> {
    private static readonly pb::MessageParser<FeatureList> _parser = new pb::MessageParser<FeatureList>(() => new FeatureList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeatureList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureList(FeatureList other) : this() {
      feature_ = other.feature_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureList Clone() {
      return new FeatureList(this);
    }

    /// <summary>Field number for the "feature" field.</summary>
    public const int FeatureFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.Feature> _repeated_feature_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.Feature.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Feature> feature_ = new pbc::RepeatedField<global::Tensorflow.Feature>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Feature> Feature {
      get { return feature_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeatureList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeatureList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!feature_.Equals(other.feature_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= feature_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      feature_.WriteTo(output, _repeated_feature_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += feature_.CalculateSize(_repeated_feature_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeatureList other) {
      if (other == null) {
        return;
      }
      feature_.Add(other.feature_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            feature_.AddEntriesFrom(input, _repeated_feature_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class FeatureLists : pb::IMessage<FeatureLists> {
    private static readonly pb::MessageParser<FeatureLists> _parser = new pb::MessageParser<FeatureLists>(() => new FeatureLists());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeatureLists> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.FeatureReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureLists() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureLists(FeatureLists other) : this() {
      featureList_ = other.featureList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureLists Clone() {
      return new FeatureLists(this);
    }

    /// <summary>Field number for the "feature_list" field.</summary>
    public const int FeatureListFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Tensorflow.FeatureList>.Codec _map_featureList_codec
        = new pbc::MapField<string, global::Tensorflow.FeatureList>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.FeatureList.Parser), 10);
    private readonly pbc::MapField<string, global::Tensorflow.FeatureList> featureList_ = new pbc::MapField<string, global::Tensorflow.FeatureList>();
    /// <summary>
    /// Map from feature name to feature list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.FeatureList> FeatureList {
      get { return featureList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeatureLists);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeatureLists other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!FeatureList.Equals(other.FeatureList)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= FeatureList.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      featureList_.WriteTo(output, _map_featureList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += featureList_.CalculateSize(_map_featureList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeatureLists other) {
      if (other == null) {
        return;
      }
      featureList_.Add(other.featureList_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            featureList_.AddEntriesFrom(input, _map_featureList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
