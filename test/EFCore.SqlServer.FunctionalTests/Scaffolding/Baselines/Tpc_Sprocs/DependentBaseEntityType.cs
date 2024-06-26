// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>",
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                baseEntityType,
                propertyCount: 2,
                navigationCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(byte?),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.SetGetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => !UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity).HasValue,
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => !UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance).HasValue);
            id.SetSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, Nullable<byte> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, Nullable<byte> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<Nullable<byte>>(id, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<Nullable<byte>>(id, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: -1);
            id.TypeMapping = SqlServerByteTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v),
                keyComparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v),
                providerValueComparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v));
            id.SetValueComparer(new NullableValueComparer<byte>(id.TypeMapping.Comparer));
            id.SetKeyValueComparer(new NullableValueComparer<byte>(id.TypeMapping.KeyComparer));
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<byte?>(id));
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id", "TestNamespace") });

            var principalId = runtimeEntityType.AddProperty(
                "PrincipalId",
                typeof(long?),
                nullable: true);
            principalId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: 0,
                relationshipIndex: 1,
                storeGenerationIndex: 0);
            principalId.TypeMapping = SqlServerLongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v));
            principalId.SetValueComparer(new NullableValueComparer<long>(principalId.TypeMapping.Comparer));
            principalId.SetKeyValueComparer(new NullableValueComparer<long>(principalId.TypeMapping.KeyComparer));
            principalId.SetCurrentValueComparer(new EntryCurrentValueComparer<long?>(principalId));
            principalId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { principalId },
                unique: true);
            index.AddAnnotation("Relational:Filter", "[PrincipalId] IS NOT NULL");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientCascade,
                unique: true,
                requiredDependent: true);

            var principal = declaringEntityType.AddNavigation("Principal",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Principal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Principal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            principal.SetGetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) == null,
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(instance),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(instance) == null);
            principal.SetSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> value) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) = value);
            principal.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> value) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) = value);
            principal.SetAccessors(
                (InternalEntityEntry entry) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>>(principal),
                null);
            principal.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            var dependent = principalEntityType.AddNavigation("Dependent",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Dependent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Dependent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            dependent.SetGetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) == null,
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(instance),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(instance) == null);
            dependent.SetSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, CompiledModelTestBase.DependentBase<Nullable<byte>> value) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) = value);
            dependent.SetMaterializationSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, CompiledModelTestBase.DependentBase<Nullable<byte>> value) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) = value);
            dependent.SetAccessors(
                (InternalEntityEntry entry) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                (InternalEntityEntry entry) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.DependentBase<Nullable<byte>>>(dependent),
                null);
            dependent.SetPropertyIndexes(
                index: 1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 4,
                storeGenerationIndex: -1);
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var principalId = runtimeEntityType.FindProperty("PrincipalId")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.Create<byte?>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<byte?>(key));
            var principal = runtimeEntityType.FindNavigation("Principal")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentBase<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<Nullable<byte>, Nullable<long>>(source.GetCurrentValue<Nullable<byte>>(id) == null ? null : ((ValueComparer<Nullable<byte>>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<byte>>(id)), source.GetCurrentValue<Nullable<long>>(principalId) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)principalId).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<long>>(principalId)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<Nullable<long>>(default(Nullable<long>) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)principalId).GetValueComparer()).Snapshot(default(Nullable<long>))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<Nullable<long>>(default(Nullable<long>)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<Nullable<long>>(source.ContainsKey("PrincipalId") ? (Nullable<long>)source["PrincipalId"] : null));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<Nullable<long>>(default(Nullable<long>)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentBase<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<Nullable<byte>, Nullable<long>, object>(source.GetCurrentValue<Nullable<byte>>(id) == null ? null : ((ValueComparer<Nullable<byte>>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Nullable<byte>>(id)), source.GetCurrentValue<Nullable<long>>(principalId) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)principalId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Nullable<long>>(principalId)), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 1,
                relationshipCount: 3,
                storeGeneratedCount: 1);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "TPC");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DependentBase<byte?>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref byte? UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(CompiledModelTestBase.DependentBase<byte?> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Principal>k__BackingField")]
        public static extern ref CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(CompiledModelTestBase.DependentBase<byte?> @this);
    }
}
