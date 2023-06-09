﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AGutierrezProgramacionNCapasEntities : DbContext
    {
        public AGutierrezProgramacionNCapasEntities()
            : base("name=AGutierrezProgramacionNCapasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<rol> rols { get; set; }
        public virtual DbSet<Aseguradora> Aseguradoras { get; set; }
        public virtual DbSet<Colonia> Colonias { get; set; }
        public virtual DbSet<DependienteTipo> DependienteTipoes { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<EmpresaPoliza> EmpresaPolizas { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Poliza> Polizas { get; set; }
        public virtual DbSet<SubPoliza> SubPolizas { get; set; }
        public virtual DbSet<Vigencia> Vigencias { get; set; }
        public virtual DbSet<Dependiente> Dependientes { get; set; }
    
        public virtual ObjectResult<ColoniaGetByIdMunicipio_Result> ColoniaGetByIdMunicipio(Nullable<int> idMunicipio)
        {
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("IdMunicipio", idMunicipio) :
                new ObjectParameter("IdMunicipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ColoniaGetByIdMunicipio_Result>("ColoniaGetByIdMunicipio", idMunicipioParameter);
        }
    
        public virtual ObjectResult<EstadoGetByIdPais_Result> EstadoGetByIdPais(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetByIdPais_Result>("EstadoGetByIdPais", idPaisParameter);
        }
    
        public virtual ObjectResult<MunicipioGetByIdEstado_Result> MunicipioGetByIdEstado(Nullable<int> idEstado)
        {
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MunicipioGetByIdEstado_Result>("MunicipioGetByIdEstado", idEstadoParameter);
        }
    
        public virtual ObjectResult<PaisGetAll_Result> PaisGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetAll_Result>("PaisGetAll");
        }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int UsuarioAdd(string nombre, string apellidoPaterno, string apellidoMaterno, string email, string userName, string passwordd, Nullable<System.DateTime> fechaNacimiento, Nullable<byte> idRol, string sexo, string telefono, string celular, string cURP, string imagen, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passworddParameter = passwordd != null ?
                new ObjectParameter("Passwordd", passwordd) :
                new ObjectParameter("Passwordd", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(byte));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, userNameParameter, passworddParameter, fechaNacimientoParameter, idRolParameter, sexoParameter, telefonoParameter, celularParameter, cURPParameter, imagenParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter);
        }
    
        public virtual ObjectResult<UsuarioUpdate_Result> UsuarioUpdate(Nullable<int> idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string userName, string passwordd, Nullable<System.DateTime> fechaNacimiento, Nullable<byte> idRol, string sexo, string telefono, string celular, string cURP, string imagen, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passworddParameter = passwordd != null ?
                new ObjectParameter("Passwordd", passwordd) :
                new ObjectParameter("Passwordd", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(byte));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioUpdate_Result>("UsuarioUpdate", idUsuarioParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, userNameParameter, passworddParameter, fechaNacimientoParameter, idRolParameter, sexoParameter, telefonoParameter, celularParameter, cURPParameter, imagenParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idUsuarioParameter);
        }
    
        public virtual ObjectResult<DependienteGetAll_Result> DependienteGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DependienteGetAll_Result>("DependienteGetAll");
        }
    
        public virtual ObjectResult<DependienteGetByIdEmpleado_Result> DependienteGetByIdEmpleado(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DependienteGetByIdEmpleado_Result>("DependienteGetByIdEmpleado", numeroEmpleadoParameter);
        }
    
        public virtual int EmpleadoAdd(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nSS, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAdd", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter);
        }
    
        public virtual int EmpleadoDelete(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoDelete", numeroEmpleadoParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetAll_Result> EmpleadoGetAll(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetAll_Result>("EmpleadoGetAll", nombreParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetById_Result> EmpleadoGetById(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetById_Result>("EmpleadoGetById", numeroEmpleadoParameter);
        }
    
        public virtual int EmpleadoUpdate(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nSS, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoUpdate", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpresaGetAll_Result> EmpresaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetAll_Result>("EmpresaGetAll");
        }
    
        public virtual int UsuarioChangeStatus(Nullable<int> idUsuario, Nullable<bool> status)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioChangeStatus", idUsuarioParameter, statusParameter);
        }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter);
        }
    
        public virtual ObjectResult<UsuarioGetByUsername_Result> UsuarioGetByUsername(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetByUsername_Result>("UsuarioGetByUsername", userNameParameter);
        }
    
        public virtual int AseguradoraDelete(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraDelete", idAseguradoraParameter);
        }
    
        public virtual ObjectResult<AseguradoraGetById_Result> AseguradoraGetById(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetById_Result>("AseguradoraGetById", idAseguradoraParameter);
        }
    
        public virtual ObjectResult<AseguradoraGetAll_Result> AseguradoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetAll_Result>("AseguradoraGetAll");
        }
    
        public virtual ObjectResult<UsuariosGetAll_Result> UsuariosGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuariosGetAll_Result>("UsuariosGetAll");
        }
    
        public virtual int AseguradoraAdd(string nombre, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaModificacion, Nullable<int> idUsuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaModificacionParameter = fechaModificacion.HasValue ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(System.DateTime));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraAdd", nombreParameter, fechaCreacionParameter, fechaModificacionParameter, idUsuarioParameter);
        }
    
        public virtual int AseguradoraUpdate(Nullable<int> idAseguradora, string nombre, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaModificacion, Nullable<int> idUsuario)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaModificacionParameter = fechaModificacion.HasValue ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(System.DateTime));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraUpdate", idAseguradoraParameter, nombreParameter, fechaCreacionParameter, fechaModificacionParameter, idUsuarioParameter);
        }
    }
}
