// See https://aka.ms/new-console-template for more information
using EntityContext;
using EntityContext.Entities;
using EntityContext.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

Console.WriteLine("Hello, World!");

//var _context = new Context();
var services = new ServiceCollection();

IContext c = new Context();
//IContext c = new CtxTest();



ICRUD<Usuario> usuario_crud = new Crud<Usuario>(c);
ICRUD<Entradas> entradas_crud = new Crud<Entradas>(c);

var a = usuario_crud.All();
var b = entradas_crud.All();

Console.WriteLine("Lista consultada");