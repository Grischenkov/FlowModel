using System.Collections.Generic;
using System.Linq;

// ReSharper disable PossibleNullReferenceException
namespace FlowModel.Model
{
    public class MockRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly Dictionary<System.Type, object> _entities;

        public MockRepository()
        {
            _entities = new Dictionary<System.Type, object>
            {
                {typeof(User), _users},
                {typeof(Unit), _units},
                {typeof(Type), _types},
                {typeof(Report), new List<Report>()},
                {typeof(Material), _materials},
                {typeof(Parameter), _parameters},
                {typeof(MaterialParameters), _materialParameters}
            };
        }
        
        
        public IEnumerable<TEntity> GetList()
        {
            return (IEnumerable<TEntity>)_entities[typeof(TEntity)];
        }

        public TEntity Get(object id)
        {
            return ((IEnumerable<TEntity>) _entities[typeof(TEntity)]).FirstOrDefault(x =>
                (int) typeof(TEntity).GetProperty("Id")?.GetValue(x, null) == (int) id);
        }

        public void Insert(TEntity entity)
        {
            var newList =  (List<TEntity>)_entities[typeof(TEntity)];
            newList.Add(entity);
            _entities[typeof(TEntity)] = newList;
        }

        public void Update(TEntity entity)
        {
            var obj = ((List<TEntity>) _entities[typeof(TEntity)]).First(x =>
                (int) typeof(TEntity).GetProperty("Id")?.GetValue(x, null) == entity.Id);
            if (obj != null)
            {
                obj = entity;
            }

        }

        public void Delete(object id)
        {
            //TODO
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            var obj = ((List<TEntity>) _entities[typeof(TEntity)]).First(x =>
                (int) typeof(TEntity).GetProperty("Id")?.GetValue(x, null) == entity.Id);
            if (obj != null)
            {
                ((List<TEntity>) _entities[typeof(TEntity)]).Remove(entity);
            }
        }


        private List<User> _users = new List<User>
        {
            new User
            {
                Id = 1,
                Login = "Researcher",
                Password = "Researcher",
                IsAdministrator = false
            },
            new User
            {
                Id = 2,
                Login = "Administrator",
                Password = "Administrator",
                IsAdministrator = true
            }
        };

        private static List<Unit> _units = new List<Unit>
        {
            new Unit
            {
                Id = 1,
                Name = ""
            },
            new Unit
            {
                Id = 2,
                Name = "кг/м^3"
            },
            new Unit
            {
                Id = 3,
                Name = "Дж/кг*С"
            },
            new Unit
            {
                Id = 4,
                Name = "С"
            },
            new Unit
            {
                Id = 5,
                Name = "Па*с^n"
            },
            new Unit
            {
                Id = 6,
                Name = "1/C"
            },
            new Unit
            {
                Id = 7,
                Name = "Вт/м^2*С"
            }
        };

        private static List<Type> _types = new List<Type>
        {
            new Type
            {
                Id = 1,
                Name = "Параметр материала"
            },
            new Type
            {
                Id = 2,
                Name = "Коэффициент модели"
            }
        };

        private static List<Material> _materials = new List<Material>
        {
            new Material
            {
                Id = 1,
                Name = "Материал 1"
            }
        };

        private static List<Parameter> _parameters = new List<Parameter>
        {
            new Parameter
            {
                Id = 1,
                Name = "Плотность",
                TypeId = 1,
                UnitId = 2
            },
            new Parameter
            {
                Id = 2,
                Name = "Теплоемкость",
                TypeId = 1,
                UnitId = 3
            },
            new Parameter
            {
                Id = 3,
                Name = "Температура плавления",
                TypeId = 1,
                UnitId = 4
            },
            new Parameter
            {
                Id = 4,
                Name = "Коэффициент консистенции при температуре приведения",
                TypeId = 2,
                UnitId = 5
            },
            new Parameter
            {
                Id = 5,
                Name = "Температурный коэффициент вязкости",
                TypeId = 2,
                UnitId = 6
            },
            new Parameter
            {
                Id = 6,
                Name = "Температура приведения",
                TypeId = 2,
                UnitId = 4
            },
            new Parameter
            {
                Id = 7,
                Name = "Индекс течения",
                TypeId = 2,
                UnitId = 1
            },
            new Parameter
            {
                Id = 8,
                Name = "Коэффициент теплоотдачи от крышки канала к материалу",
                TypeId = 2,
                UnitId = 7
            }
        };

        private List<MaterialParameters> _materialParameters = new List<MaterialParameters>
        {
            new MaterialParameters
            {
                Id = 1,
                MaterialId = 1,
                ParameterId = 1,
                ParameterValue = 920
            },
            new MaterialParameters
            {
                Id = 2,
                MaterialId = 1,
                ParameterId = 2,
                ParameterValue = 2300
            },
            new MaterialParameters
            {
                Id = 3,
                MaterialId = 1,
                ParameterId = 3,
                ParameterValue = 120
            },
            new MaterialParameters
            {
                Id = 4,
                MaterialId = 1,
                ParameterId = 4,
                ParameterValue = 50000
            },
            new MaterialParameters
            {
                Id = 5,
                MaterialId = 1,
                ParameterId = 5,
                ParameterValue = 0.03
            },
            new MaterialParameters
            {
                Id = 6,
                MaterialId = 1,
                ParameterId = 6,
                ParameterValue = 120
            },
            new MaterialParameters
            {
                Id = 7,
                MaterialId = 1,
                ParameterId = 7,
                ParameterValue = 0.35
            },
            new MaterialParameters
            {
                Id = 8,
                MaterialId = 1,
                ParameterId = 8,
                ParameterValue = 250
            }
        };
    }
}