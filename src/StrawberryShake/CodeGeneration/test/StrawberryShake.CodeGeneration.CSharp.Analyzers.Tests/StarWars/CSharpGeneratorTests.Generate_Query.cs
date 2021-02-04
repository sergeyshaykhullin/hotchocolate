﻿// Code:
// DroidEntity

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DroidEntity
    {
        public global::StrawberryShake.EntityId Id { get; }

        public global::System.String Name { get; set; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; set; }
    }
}


// HumanEntity

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class HumanEntity
    {
        public global::StrawberryShake.EntityId Id { get; }

        public global::System.String Name { get; set; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; set; }
    }
}


// Episode

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public enum Episode
    {
        NewHope,
        Empire,
        Jedi
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroFactory
        : global::StrawberryShake.IOperationResultDataFactory<GetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> _getHero_Hero_DroidFromDroidEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> _getHero_Hero_HumanFromHumanEntityMapper;

        public GetHeroFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> getHero_Hero_DroidFromDroidEntityMapper,
            global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> getHero_Hero_HumanFromHumanEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_DroidFromDroidEntityMapper = getHero_Hero_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_DroidFromDroidEntityMapper));
            _getHero_Hero_HumanFromHumanEntityMapper = getHero_Hero_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_HumanFromHumanEntityMapper));
        }

        public GetHero Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is GetHeroInfo info)
            {
                IGetHero_Hero hero = default!;

                var heroInfo = info.Hero ?? throw new global::System.ArgumentNullException();
                if (heroInfo.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal
                ))
                {
                    hero = _getHero_Hero_DroidFromDroidEntityMapper.Map(_entityStore.GetEntity<DroidEntity>(heroInfo) ?? throw new global::System.ArgumentNullException());
                }

                if (heroInfo.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal
                ))
                {
                    hero = _getHero_Hero_HumanFromHumanEntityMapper.Map(_entityStore.GetEntity<HumanEntity>(heroInfo) ?? throw new global::System.ArgumentNullException());
                }

                return new GetHero(hero);
            }

            throw new global::System.ArgumentException("GetHeroInfo expected.");
        }
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly ulong _version;

        public GetHeroInfo(
            global::StrawberryShake.EntityId? hero,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            ulong version)
        {
            Hero = hero;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::StrawberryShake.EntityId? Hero { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public ulong Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(ulong version)
        {
            return new GetHeroInfo(
                Hero,
                _entityIds,
                _version
            );
        }
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero
        : IGetHero
    {
        public GetHero(IGetHero_Hero? hero)
        {
            Hero = hero;
        }

        public IGetHero_Hero? Hero { get; }
    }
}


// GetHero_Hero_Droid

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid>
    {
        public GetHero_Hero_Droid Map(DroidEntity entity)
        {
            return new GetHero_Hero_Droid(
                entity.Name,
                entity.AppearsIn
            );
        }
    }
}


// GetHero_Hero_Droid

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Droid
        : IGetHero_Hero
    {
        public GetHero_Hero_Droid(
            global::System.String name,
            global::System.Collections.Generic.IReadOnlyList<Episode?>? appearsIn)
        {
            Name = name;
            AppearsIn = appearsIn;
        }

        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// GetHero_Hero_Human

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetHero_Hero_Human Map(HumanEntity entity)
        {
            return new GetHero_Hero_Human(
                entity.Name,
                entity.AppearsIn
            );
        }
    }
}


// GetHero_Hero_Human

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Human
        : IGetHero_Hero
    {
        public GetHero_Hero_Human(
            global::System.String name,
            global::System.Collections.Generic.IReadOnlyList<Episode?>? appearsIn)
        {
            Name = name;
            AppearsIn = appearsIn;
        }

        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// IGetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero
    {
        public IGetHero_Hero? Hero { get; }
    }
}


// IGetHero_Hero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero
    {
        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// GetHeroQuery

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQueryDocument
        : global::StrawberryShake.IDocument
    {
        private const global::System.String _bodyString =
            @"query GetHero {
  hero(episode: NEW_HOPE) {
    name
    appearsIn
  }
}";
        private static readonly byte[] _body = global::System.Text.Encoding.UTF8.GetBytes(_bodyString);

        private GetHeroQueryDocument()
        {
        }

        public static GetHeroQueryDocument Instance { get; } = new GetHeroQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<byte> Body => _body;

        public override string ToString()
        {
            return _bodyString;
        }
    }
}


// GetHeroQuery

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetHero> _operationExecutor;

        public GetHeroQuery(global::StrawberryShake.IOperationExecutor<IGetHero> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetHero>> Execute(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken
                )
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetHero>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {
            return new(
                "IGetHero",
                GetHeroQueryDocument.Instance
            );
        }
    }
}


// GetHeroBuilder

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IGetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<IGetHero> _resultDataFactory;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Episode> _episodeParser;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetHeroBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<IGetHero> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _episodeParser = serializerResolver.GetLeafValueParser<global::System.String, Episode>("Episode")
                 ?? throw new global::System.ArgumentNullException(nameof(_episodeParser));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentNullException(nameof(_stringParser));
        }

        public global::StrawberryShake.IOperationResult<IGetHero> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetHero Result, GetHeroInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<IGetHero>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null
            );
        }

        private (IGetHero, GetHeroInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();

            global::StrawberryShake.EntityId? heroId = UpdateIGetHero_HeroEntity(
                global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj, "hero"),
                entityIds
            );

            var resultInfo = new GetHeroInfo(
                heroId,
                entityIds,
                session.Version
            );

            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::StrawberryShake.EntityId? UpdateIGetHero_HeroEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals("GetHero_Hero_Droid", global::System.StringComparison.Ordinal))
            {
                DroidEntity entity = _entityStore.GetOrCreate<DroidEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.AppearsIn = DeserializeEpisodeArray(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "appearsIn"));

                return entityId;
            }

            if (entityId.Name.Equals("GetHero_Hero_Human", global::System.StringComparison.Ordinal))
            {
                HumanEntity entity = _entityStore.GetOrCreate<HumanEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.AppearsIn = DeserializeEpisodeArray(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "appearsIn"));

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<Episode?>? DeserializeEpisodeArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var episodes = new global::System.Collections.Generic.List<Episode?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                episodes.Add(DeserializeEpisode(child));
            }

            return episodes;
        }

        private Episode? DeserializeEpisode(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _episodeParser.Parse(obj.Value.GetString()!);
        }
    }
}


// FooClient

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FooClient
    {
        private readonly GetHeroQuery _getHeroQuery;

        public FooClient(GetHeroQuery getHeroQuery)
        {
            _getHeroQuery = getHeroQuery
                 ?? throw new global::System.ArgumentNullException(nameof(getHeroQuery));
        }

        // TODO : MAKE PROP
        public GetHeroQuery GetHeroQuery()
        {
            return _getHeroQuery;
        }
    }
}


// EntityIdFactory

[global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
public static partial class EntityIdFactory
{
    public static global::StrawberryShake.EntityId CreateEntityId(global::System.Text.Json.JsonElement obj)
    {
        string typeName = obj.GetProperty("__typename").GetString()!;

        return typeName switch
        {
            "Droid" => CreateDroidEntityId(obj, typeName),
            "Human" => CreateHumanEntityId(obj, typeName),
            _ => throw new global::System.NotSupportedException()
        };
    }

    // TODO : Make Privat
    public static global::StrawberryShake.EntityId CreateDroidEntityId(
        global::System.Text.Json.JsonElement obj,
        global::System.String type)
    {
        return new global::StrawberryShake.EntityId(
            type,
            obj.GetProperty("id").GetString()!);
    }

    public static global::StrawberryShake.EntityId CreateHumanEntityId(
        global::System.Text.Json.JsonElement obj,
        global::System.String type)
    {
        return new global::StrawberryShake.EntityId(
            type,
            obj.GetProperty("id").GetString()!);
    }
}

