// <auto-generated />
using Criptomonedas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Criptomonedas.Migrations
{
    [DbContext(typeof(CriptoContext))]
    [Migration("20211215144459_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Criptomonedas.Models.CriptoItems", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ValorActual")
                        .HasColumnType("float");

                    b.Property<double>("ValorMaximo")
                        .HasColumnType("float");

                    b.HasKey("Nombre");

                    b.ToTable("CriptoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
