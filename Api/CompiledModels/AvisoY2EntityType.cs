﻿// <auto-generated />
using System;
using System.Reflection;
using Api.Reportes;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Api.CompiledModels
{
    internal partial class AvisoY2EntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Api.Reportes.AvisoY2",
                typeof(AvisoY2),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(Guid),
                propertyInfo: typeof(AvisoY2).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AvisoY2).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            id.TypeMapping = SqliteGuidTypeMapping.Default;

            var corregidoPorMantenimiento = runtimeEntityType.AddProperty(
                "CorregidoPorMantenimiento",
                typeof(bool),
                propertyInfo: typeof(AvisoY2).GetProperty("CorregidoPorMantenimiento", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AvisoY2).GetField("<CorregidoPorMantenimiento>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            corregidoPorMantenimiento.TypeMapping = BoolTypeMapping.Default.Clone(
                comparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                keyComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                providerValueComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var idEvento = runtimeEntityType.AddProperty(
                "IdEvento",
                typeof(Guid),
                propertyInfo: typeof(AvisoY2).GetProperty("IdEvento", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AvisoY2).GetField("<IdEvento>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            idEvento.TypeMapping = SqliteGuidTypeMapping.Default;

            var numeroAvisoY2 = runtimeEntityType.AddProperty(
                "NumeroAvisoY2",
                typeof(int),
                propertyInfo: typeof(AvisoY2).GetProperty("NumeroAvisoY2", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AvisoY2).GetField("<NumeroAvisoY2>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            numeroAvisoY2.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "AvisosY2");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}