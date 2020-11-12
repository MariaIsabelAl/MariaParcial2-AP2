#pragma checksum "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\ConsultaVentas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f28e0c76696b02c947c702ca387bac5b0591f1bb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MariaParcial2_AP2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using MariaParcial2_AP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using MariaParcial2_AP2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\ConsultaVentas.razor"
using MariaParcial2_AP2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\ConsultaVentas.razor"
using MariaParcial2_AP2.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consultaVentas")]
    public partial class ConsultaVentas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\ConsultaVentas.razor"
       

    public int filtro { get; set; }
    public string criterio { get; set; }
    public List<Ventas> lista = new List<Ventas>();



    private void Consultar()
    {
        try
        {
            switch (filtro)
            {
                case 0: //Todos
                    this.lista = VentasBLL.GetList(p => true);
                    break;
                case 1: //Id
                    int ID = GetId();
                    this.lista = VentasBLL.GetList(p => p.VentaId == ID);
                    break;
                case 2: //Fecha
                    DateTime fecha = GetFecha(); 
                    this.lista = VentasBLL.GetList(p => p.Fecha == fecha);
                    break;
                case 3: //Monto
                    double monto = GetMonto();
                    this.lista = VentasBLL.GetList(p => p.Monto == monto);
                    break;
                case 4: //ClienteId
                    int clienteId = GetClienteId();
                    this.lista = VentasBLL.GetList(p => p.ClienteId == clienteId);
                    break;
                case 5://Balance
                    double balance = GetBalance();
                    this.lista = VentasBLL.GetList(p => p.Balance == balance);
                    break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

     private double Get()
    {
        double valor = 0;
        Ventas ventas= new Ventas();
        Cobros cobros= new Cobros();

        try
        {
            if(cobros.Cobrado==0){
                valor = ventas.Balance;
            }
            else{
                valor = ventas.Balance-cobros.Cobrado;
            }
            
            return valor;
        }
        catch (Exception)
        {

            toast.ShowError("La monto debe ser numerico..");
        }

        return valor;
    }


    private int GetId()
    {
        int resultado = 0;

        try
        {
            resultado = Convert.ToInt32(criterio);
            return resultado;
        }
        catch (Exception)
        {

            toast.ShowError("El Id debe ser numerico..");
        }

        return resultado;
    }

    private DateTime GetFecha()
    {
        DateTime fecha= DateTime.Now;
        try
        {
            fecha = Convert.ToDateTime(criterio);
            return fecha;
        }
        catch (Exception)
        {

            toast.ShowError("La fecha debe ser numerico..");
        }

        return fecha;
    }

    private double GetMonto()
    {
        double monto = 0;

        try
        {
            monto = Convert.ToDouble(criterio);
            return monto;
        }
        catch (Exception)
        {

            toast.ShowError("La monto debe ser numerico..");
        }

        return monto;
    }

    private int GetClienteId()
    {
        int clienteId = 0;

        try
        {
            clienteId = Convert.ToInt32(criterio);
            return clienteId;
        }
        catch (Exception)
        {

            toast.ShowError("El ClienteId debe ser numerico..");
        }

        return clienteId;
    }

    private double GetBalance()
    {
        double balance = 0;

        try
        {
            balance = Convert.ToDouble(criterio);
            return balance;
        }
        catch (Exception)
        {

            toast.ShowError("El balance debe ser numerico..");
        }

        return balance;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
