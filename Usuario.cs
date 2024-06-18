using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionNCapas
{
	public class Usuario
	{
		public static void Add()
		{
			ML.Usuario usuario = new ML.Usuario();
			Console.WriteLine("Escribe el nombre:");
			usuario.Nombre = Console.ReadLine();
			Console.WriteLine("Escriba el ApellidoPaterno:");
			usuario.ApellidoPaterno = Console.ReadLine();
			Console.WriteLine("Escriba el ApellidoMaterno:");
			usuario.ApellidoMaterno = Console.ReadLine();
			Console.WriteLine("Escribe el Correo");
			usuario.Email = Console.ReadLine();
			Console.WriteLine("Escribe el NombreUsuario");
			usuario.NombreUsuario = Console.ReadLine();

			Console.WriteLine("Escribe la contraseña");
			usuario.Password = Console.ReadLine();
			Console.WriteLine("Escribe el sexo");
			usuario.Sexo = Console.ReadLine();
			Console.WriteLine("Escribe el telefono");
			usuario.Telefono = Console.ReadLine();
			Console.WriteLine("Escribe el Celular");
			usuario.celular = Console.ReadLine();
			Console.WriteLine("Escribe el CURP");
			usuario.Curp = Console.ReadLine();
			Console.WriteLine("Escribe la fecha de Nacimiento");
			//yyyy-mm-dd
			//para agregar un formato tipo date hay que convertirlo con DateTime.parse
			usuario.FechaNacimiento =DateTime.Parse (Console.ReadLine());



			bool ressultado = BL.Usuario.AddEF(usuario);

			if (ressultado)
			{

				Console.WriteLine("Se inserto Correctamente");

			}
			else
			{
				Console.WriteLine("Ocurrio un error");
			}
		}


		public static void Update()
		{
			ML.Usuario usuario = new ML.Usuario();
			Console.WriteLine("Ingrese el IdUsuario:");
			usuario.IdUsuario = int.Parse(Console.ReadLine());


			Console.WriteLine("Escribe el nombre:");
			usuario.Nombre = Console.ReadLine();
			Console.WriteLine("Escriba el ApellidoPaterno:");
			usuario.ApellidoPaterno = Console.ReadLine();
			Console.WriteLine("Escriba el ApellidoMaterno:");
			usuario.ApellidoMaterno = Console.ReadLine();
			Console.WriteLine("Escribe el Correo");
			usuario.Email = Console.ReadLine();
			Console.WriteLine("Escribe el NombreUsuario");
			usuario.NombreUsuario = Console.ReadLine();

			Console.WriteLine("Escribe la contraseña");
			usuario.Password = Console.ReadLine();
			Console.WriteLine("Escribe el sexo");
			usuario.Sexo = Console.ReadLine();
			Console.WriteLine("Escribe el telefono");
			usuario.Telefono = Console.ReadLine();
			Console.WriteLine("Escribe el Celular");
			usuario.celular = Console.ReadLine();
			Console.WriteLine("Escribe el CURP");
			usuario.Curp = Console.ReadLine();
            Console.WriteLine("Escribe la fecha de Nacimiento");
            //yyyy-mm-dd
            //para agregar un formato tipo date hay que convertirlo con DateTime.parse
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());


            bool resultado = BL.Usuario.UpdateEF(usuario);

			if (resultado)
			{

				Console.WriteLine("Se Actualizo Correctamente");

			}
			else
			{
				Console.WriteLine("Ocurrio un error");
			}
		}

		////Listo
		//public static void Delete()
		//{
		//	ML.Usuario usuario = new ML.Usuario();
		//	Console.WriteLine("Ingrese el IdUsuario:");
		//	usuario.IdUsuario = int.Parse(Console.ReadLine());



		//	bool resultado = BL.Usuario.DeleteEF(usuario.IdUsuario);

		//	if (resultado)
		//	{

		//		Console.WriteLine("Se Elimino Correctamente");

		//	}
		//	else
		//	{
		//		Console.WriteLine("Ocurrio un error");
		//	}
		//}





		//public static void GetAll()
		//{
		//	//Se crea objeto usuario y se le asignan valores de BL. Usuario.GetAll
		//	var resultado = BL.Usuario.GetAllEF();
		//	//Si el resultado de la variable bool es verdadero
		//	if (resultado.Item1 == true)
		//	{	// se hace un ciclo para la variable usuarioregistro esta dentro de resultado
		//		// entonces manda a llamar a el modelo y a la lista de usuarios
  //              foreach (ML.Usuario usuarioRegistro in resultado.Item3.usuarioss)
  //              {
  //                  Console.WriteLine("IdUsuario: " + usuarioRegistro.IdUsuario);
  //                  Console.WriteLine("Nombre: " + usuarioRegistro.Nombre);
  //                  Console.WriteLine("ApellitoPaterno: " + usuarioRegistro.ApellidoPaterno);
  //                  Console.WriteLine("ApellidoMaterno: " + usuarioRegistro.ApellidoMaterno);
  //                  Console.WriteLine("Correo: " + usuarioRegistro.Email);
  //                  Console.WriteLine("NombreUsuario: " + usuarioRegistro.NombreUsuario);
  //                  Console.WriteLine("Password: " + usuarioRegistro.Password);
  //                  Console.WriteLine("Sexo: " + usuarioRegistro.Sexo);
  //                  Console.WriteLine("Telefono: " + usuarioRegistro.Telefono);
  //                  Console.WriteLine("Celular: " + usuarioRegistro.celular);
  //                  Console.WriteLine("CURP: " + usuarioRegistro.Curp);
  //                  Console.WriteLine("FechaNacimiento: " + usuarioRegistro.FechaNacimiento);
  //                  Console.WriteLine("Rol dentro de la empresa: " + usuarioRegistro.Rolp.IdRol);
  //                  Console.WriteLine("Rol: "+usuarioRegistro.Rolp.NombreRol);
  //                  Console.WriteLine("--------------------------------------------------------------");

  //              }
  //              Console.ReadKey();
  //          }
		//	else { Console.WriteLine("Ocurrio un error "); }

		//	Console.ReadKey();

		//}


		//public static void GetById()
		//{

		//	Console.WriteLine("Inserta el ID que desees consultar");
			
		//	int IdUsuario = int.Parse(Console.ReadLine());
  //          //ML.Usuario usuario = new ML.Usuario();
  //          var resultado = BL.Usuario.GetByIdEF(IdUsuario);
		//	//y aqui tambien esta mal, quien se queda la informacion es resultado, entonces ahi adentro tenemos la informacion
		//	if (resultado.Item1 == true)
		//	{
		//		ML.Usuario usuario = new ML.Usuario();
		//		//este usuario que acabas de crear si te das cuenta no tiene informacion porque literal lo acabas de crear y jamas
		//		//le diste informacion
		//		//lo que tendrias que hacer es a ese usuario pasarle la informacion que regreso tu tupla
		//		usuario = resultado.Item2;
		//		//y ahora si a ese usuario ya le pasaste la informacion,
		//		//vale? SI ESTA BIEN, GRACIAS !!!
  //              Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
  //              Console.WriteLine("Nombre: " + usuario.Nombre);
  //              Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
  //              Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
  //              Console.WriteLine("Correo: " + usuario.Email);

  //              Console.WriteLine("NombreUsuario: " + usuario.NombreUsuario);
  //              Console.WriteLine("Password: " + usuario.Password);
  //              Console.WriteLine("Sexo: " + usuario.Sexo);
  //              Console.WriteLine("Telefono: " + usuario.Telefono);
  //              Console.WriteLine("Celular: " + usuario.celular);
  //              Console.WriteLine("CURP: " + usuario.Curp);
  //              Console.WriteLine("FechaNacimiento: " + usuario.FechaNacimiento);
  //              Console.WriteLine("Rol dentro de la empresa: " + usuario.Rolp.IdRol);
  //              Console.WriteLine("Rol: " + usuario.Rolp.NombreRol);
  //          }

		//}


  //      public static void AddLINQ()
  //      {
  //          ML.Usuario usuario = new ML.Usuario();
  //          Console.WriteLine("Escribe el nombre:");
  //          usuario.Nombre = Console.ReadLine();
  //          Console.WriteLine("Escriba el ApellidoPaterno:");
  //          usuario.ApellidoPaterno = Console.ReadLine();
  //          Console.WriteLine("Escriba el ApellidoMaterno:");
  //          usuario.ApellidoMaterno = Console.ReadLine();
  //          Console.WriteLine("Escribe el Correo");
  //          usuario.Email = Console.ReadLine();
  //          Console.WriteLine("Escribe el NombreUsuario");
  //          usuario.NombreUsuario = Console.ReadLine();

  //          Console.WriteLine("Escribe la contraseña");
  //          usuario.Password = Console.ReadLine();
  //          Console.WriteLine("Escribe el sexo");
  //          usuario.Sexo = Console.ReadLine();
  //          Console.WriteLine("Escribe el telefono");
  //          usuario.Telefono = Console.ReadLine();
  //          Console.WriteLine("Escribe el Celular");
  //          usuario.celular = Console.ReadLine();
  //          Console.WriteLine("Escribe el CURP");
  //          usuario.Curp = Console.ReadLine();
  //          Console.WriteLine("Escribe la fecha de Nacimiento");
		//	Console.WriteLine(" EScribe tu rol en la empresa");
		//	Console.WriteLine("1.- Usuario 3.- Administrador 5.- Invitado ");
			
  //          //yyyy-mm-dd
  //          //para agregar un formato tipo date hay que convertirlo con DateTime.parse
  //          usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());



  //          var ressultado = BL.Usuario.AddLINQ(usuario);

  //          if (ressultado.Item1)
  //          {

  //              Console.WriteLine("Se inserto Correctamente");

  //          }
  //          else
  //          {
  //              Console.WriteLine("Ocurrio un error");
  //          }
  //      }


  //      public static void GetAllLINQ()
  //      {
  //          //Se crea objeto usuario y se le asignan valores de BL. Usuario.GetAllLinq
  //          var resultado = BL.Usuario.GetAllLINQ();
  //          //Si el resultado de la variable bool es verdadero
  //          if (resultado.Item1 == true)
  //          {   // se hace un ciclo para la variable usuarioregistro esta dentro de resultado
  //              // entonces manda a llamar a el modelo y a la lista de usuarios
  //              foreach (ML.Usuario usuarioRegistro in resultado.Item3.usuarioss)
  //              {
  //                  Console.WriteLine("IdUsuario: " + usuarioRegistro.IdUsuario);
  //                  Console.WriteLine("Nombre: " + usuarioRegistro.Nombre);
  //                  Console.WriteLine("ApellitoPaterno: " + usuarioRegistro.ApellidoPaterno);
  //                  Console.WriteLine("ApellidoMaterno: " + usuarioRegistro.ApellidoMaterno);
  //                  Console.WriteLine("Correo: " + usuarioRegistro.Email);
  //                  Console.WriteLine("NombreUsuario: " + usuarioRegistro.NombreUsuario);
  //                  Console.WriteLine("Password: " + usuarioRegistro.Password);
  //                  Console.WriteLine("Sexo: " + usuarioRegistro.Sexo);
  //                  Console.WriteLine("Telefono: " + usuarioRegistro.Telefono);
  //                  Console.WriteLine("Celular: " + usuarioRegistro.celular);
  //                  Console.WriteLine("CURP: " + usuarioRegistro.Curp);
  //                  Console.WriteLine("FechaNacimiento: " + usuarioRegistro.FechaNacimiento);
  //                  Console.WriteLine("--------------------------------------------------------------");

  //              }
  //              Console.ReadKey();
  //          }
  //          else { Console.WriteLine("Ocurrio un error "); }

  //          Console.ReadKey();

  //      }


  //      public static void DeleteLINQ()
  //      {
  //          ML.Usuario usuario = new ML.Usuario();
  //          Console.WriteLine("Ingrese el IdUsuario:");
  //          usuario.IdUsuario = int.Parse(Console.ReadLine());



  //          var resultado = BL.Usuario.DeleteLINQ(usuario);

  //          if (resultado.Item1)
  //          {

  //              Console.WriteLine("Se Elimino Correctamente");

  //          }
  //          else
  //          {
  //              Console.WriteLine("Ocurrio un error");
  //          }
  //      }


  //      public static void UpdateLINQ()
  //      {
  //          ML.Usuario usuario = new ML.Usuario();
  //          Console.WriteLine("Ingrese el IdUsuario:");
  //          usuario.IdUsuario = int.Parse(Console.ReadLine());


  //          Console.WriteLine("Escribe el nombre:");
  //          usuario.Nombre = Console.ReadLine();
  //          Console.WriteLine("Escriba el ApellidoPaterno:");
  //          usuario.ApellidoPaterno = Console.ReadLine();
  //          Console.WriteLine("Escriba el ApellidoMaterno:");
  //          usuario.ApellidoMaterno = Console.ReadLine();
  //          Console.WriteLine("Escribe el Correo");
  //          usuario.Email = Console.ReadLine();
  //          Console.WriteLine("Escribe el NombreUsuario");
  //          usuario.NombreUsuario = Console.ReadLine();

  //          Console.WriteLine("Escribe la contraseña");
  //          usuario.Password = Console.ReadLine();
  //          Console.WriteLine("Escribe el sexo");
  //          usuario.Sexo = Console.ReadLine();
  //          Console.WriteLine("Escribe el telefono");
  //          usuario.Telefono = Console.ReadLine();
  //          Console.WriteLine("Escribe el Celular");
  //          usuario.celular = Console.ReadLine();
  //          Console.WriteLine("Escribe el CURP");
  //          usuario.Curp = Console.ReadLine();
  //          Console.WriteLine("Escribe la fecha de Nacimiento");
  //          //yyyy-mm-dd
  //          //para agregar un formato tipo date hay que convertirlo con DateTime.parse
  //          usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());


  //          var resultado = BL.Usuario.UpdateLINQ(usuario); //USUARIO

  //          if (resultado.Item1) 
  //          {

  //              Console.WriteLine("Se Actualizo Correctamente");

  //          }
  //          else
  //          {
  //              Console.WriteLine("Ocurrio un error");
  //          }
  //      }




  //      public static void GetByIdLINQ()
  //      {

  //          Console.WriteLine("Inserta el ID que desees consultar");

  //          int IdUsuario = int.Parse(Console.ReadLine());
  //          //ML.Usuario usuario = new ML.Usuario();
  //          var resultado = BL.Usuario.GetByIdLINQ(IdUsuario);
  //          //y aqui tambien esta mal, quien se queda la informacion es resultado, entonces ahi adentro tenemos la informacion
  //          if (resultado.Item1 == true)
  //          {
  //              //ML.Usuario usuario = new ML.Usuario();
  //              //este usuario que acabas de crear si te das cuenta no tiene informacion porque literal lo acabas de crear y jamas
  //              //le diste informacion
  //              //lo que tendrias que hacer es a ese usuario pasarle la informacion que regreso tu tupla
  //              var usuario = resultado.Item3;
  //              //y ahora si a ese usuario ya le pasaste la informacion,
  //              //vale? SI ESTA BIEN, GRACIAS !!!
  //              Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
  //              Console.WriteLine("Nombre: " + usuario.Nombre);
  //              Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
  //              Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
  //              Console.WriteLine("Correo: " + usuario.Email);

  //              Console.WriteLine("NombreUsuario: " + usuario.NombreUsuario);
  //              Console.WriteLine("Password: " + usuario.Password);
  //              Console.WriteLine("Sexo: " + usuario.Sexo);
  //              Console.WriteLine("Telefono: " + usuario.Telefono);
  //              Console.WriteLine("Celular: " + usuario.celular);
  //              Console.WriteLine("CURP: " + usuario.Curp);
  //              Console.WriteLine("FechaNacimiento: " + usuario.FechaNacimiento);
  //          }

  //      }

    }

}


