using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Neo4jClient;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
using System.Text;


namespace Progra1.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
    }

    public class Servicio
    {
        public int IdServicio { get; set; }
    }

    public class Categoria
    {
        public int IdCategoria { get; set; }
    }

    public class Neo4jStore
    {
        static Neo4jStore()
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/data/"), "neo4j", "mirainikki")
            {
                JsonContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            client.Connect();
        }

        void AgregarPersona(int id, GraphClient client)
        {
            var actor = new Persona {IdPersona = id};

            client.Cypher
                .Create("(p:Persona {ident:nuevaPersona})")
                .WithParam("nuevaPersona", id)
                .ExecuteWithoutResultsAsync()
                .Wait();
        }

        void AgregarServicio(int id, GraphClient client)
        {
            var actor = new Servicio {IdServicio = id };

            client.Cypher
                .Create("(s:Servicio {ident:nuevoServicio})")
                .WithParam("nuevoServicio", id)
                .ExecuteWithoutResultsAsync()
                .Wait();
        }

        void AgregarCategoria(int id, GraphClient client)
        {
            var actor = new Categoria { IdCategoria = id };

            client.Cypher
                .Create("(c:Persona {ident:nuevaCategoria})")
                .WithParam("nuevaCategoria", id)
                .ExecuteWithoutResultsAsync()
                .Wait();
        }

        void Persona_x_Categoria(int idP, int idC, GraphClient client)
        {
            client.Cypher
                .Match("(p:Persona)", "(c:Categoria)")
                .Where((Persona p) => p.IdPersona == idP)
                .AndWhere((Categoria c) => c.IdCategoria == idC)
                .Create("(p)-[l:LIKE]->(c)")
                .ExecuteWithoutResultsAsync()
                .Wait();
        }

        void Persona_x_Servicio(int idP, int idS, int calificacion, string comentarios, GraphClient client)
        {
            client.Cypher
                .Match("(p:Persona)", "(s:Servicio)")
                .Where((Persona p) => p.IdPersona == idP)
                .AndWhere((Servicio s) => s.IdServicio == idS)
                .Create("(p)-[o:OPINION {}]->(s)") //falta
                .ExecuteWithoutResultsAsync()
                .Wait();
        }
    }
}