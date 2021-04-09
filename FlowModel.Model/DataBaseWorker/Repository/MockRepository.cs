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
                {
                    typeof(User), 
                    new List<User>
                    {
                        new User
                        {
                            Id = 1,
                            Login = "Researcher",
                            Password = "Researcher",
                            IsAdministrator = false
                        }, new User
                        {
                            Id = 2,
                            Login = "Administrator",
                            Password = "Administrator",
                            IsAdministrator = true                 
                        }
                    }
                },
                {
                    typeof(Unit), 
                    new List<Unit>
                    {
                        new Unit
                        {
                            Id = 1,
                            Name = ""
                        }, new Unit
                        {
                            Id = 2,
                            Name = "кг/м^3"
                        }, new Unit
                        {
                            Id = 3,
                            Name = "Дж/кг*С"
                        }, new Unit
                        {
                            Id = 4,
                            Name = "С"
                        }, new Unit
                        {
                            Id = 5,
                            Name = "Па*с^n"
                        }, new Unit
                        {
                            Id = 6,
                            Name = "1/C"
                        }, new Unit
                        {
                            Id = 7,
                            Name = "Вт/м^2*С"
                        }
                    }
                },
                {
                    typeof(Type), 
                    new List<Type>
                    {
                        new Type
                        {
                            Id = 1,
                            Name = "MaterialParameter"
                        }, new Type {
                            Id = 2,
                            Name = "ModelCoefficient"
                        }
                    }
                },
                {
                    typeof(Report), 
                    new List<Report>
                    {
                        
                    }
                },
                {
                    typeof(Material), 
                    new List<Material>
                    {
                        
                    }
                },
                {
                    typeof(Parameter), 
                    new List<Parameter>
                    {
                        new Parameter
                        {
                            Id = 1,
                            Name = "Density",
                            TypeId = 1,
                            UnitId = 2
                        }, new Parameter
                        {
                            Id = 2,
                            Name = "Heat capacity",
                            TypeId = 1,
                            UnitId = 3
                        }, new Parameter
                        {
                            Id = 3,
                            Name = "Melting temperature",
                            TypeId = 1,
                            UnitId = 4
                        }, new Parameter
                        {
                            Id = 4,
                            Name = "Consistency index",
                            TypeId = 2,
                            UnitId = 5
                        }, new Parameter
                        {
                            Id = 5,
                            Name = "Viscosity index",
                            TypeId = 2,
                            UnitId = 6
                        }, new Parameter
                        {
                            Id = 6,
                            Name = "Reference temperature",
                            TypeId = 2,
                            UnitId = 4
                        }, new Parameter
                        {
                            Id = 7,
                            Name = "Flow index",
                            TypeId = 2,
                            UnitId = 1
                        }, new Parameter
                        {
                            Id = 8,
                            Name = "Heat transfer index",
                            TypeId = 2,
                            UnitId = 7
                        }
                    }
                },
                {
                    typeof(MaterialParameters), 
                    new List<MaterialParameters>
                    {
                        
                    }
                }
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

        public void Delete(TEntity entity)
        {
            var obj = ((List<TEntity>) _entities[typeof(TEntity)]).First(x =>
                (int) typeof(TEntity).GetProperty("Id")?.GetValue(x, null) == entity.Id);
            if (obj != null)
            {
                ((List<TEntity>) _entities[typeof(TEntity)]).Remove(entity);
            }
        }
    }
}