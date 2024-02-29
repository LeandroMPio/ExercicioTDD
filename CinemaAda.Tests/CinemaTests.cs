using FluentAssertions;

namespace CinemaAda.Tests;

public class CinemaTests
{
    /*
     O Cinema Ada é uma franquia nacional e disponibiliza valor de meia entrada nas seguintes condições:
        Estudante;
        Doador de sangue;
        Trabalhador da prefeitura e a prefeitura possui contrato firmado com o cinema.
        Realize um questionário S e N e exiba se a pessoa tem direito a meia entrada ou não.
     */
    [Fact]
    public void Cinema_MeiaEntrada_DeveRetornarVerdadeiroSeEstudante()
    {
        //Arrange
        var cliente = new Cliente
        {
            CPF = "12345678910",
            Nome = "Leandro",
            Estudante = true,
            DoadorDeSangue = false,
            TrabalhaNaPrefeitura = false,
            PrefeituraTemContratoComCinema = false
        };
        var cinema = new Cinema();

        //Act
        var result = cinema.MeiaEntrada(cliente);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Cinema_MeiaEntrada_DeveRetornarVerdadeiroSeDoadorDeSangue()
    {
        //Arrange
        var cliente = new Cliente
        {
            CPF = "12345678910",
            Nome = "Leandro",
            Estudante = false,
            DoadorDeSangue = true,
            TrabalhaNaPrefeitura = false,
            PrefeituraTemContratoComCinema = false
        };
        var cinema = new Cinema();

        //Act
        var result = cinema.MeiaEntrada(cliente);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Cinema_MeiaEntrada_DeveRetornarVerdadeiroSeTrabalhaNaPrefeituraETemContrato()
    {
        //Arrange
        var cliente = new Cliente
        {
            CPF = "12345678910",
            Nome = "Leandro",
            Estudante = false,
            DoadorDeSangue = false,
            TrabalhaNaPrefeitura = true,
            PrefeituraTemContratoComCinema = true
        };
        var cinema = new Cinema();

        //Act
        var result = cinema.MeiaEntrada(cliente);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Cinema_MeiaEntrada_DeveRetornarFalsoSePrefeituraNaoTiverContratoComCinema()
    {
        //Arrange
        var cliente = new Cliente
        {
            CPF = "12345678910",
            Nome = "Leandro",
            Estudante = false,
            DoadorDeSangue = false,
            TrabalhaNaPrefeitura = true,
            PrefeituraTemContratoComCinema = false
        };
        var cinema = new Cinema();

        //Act
        var result = cinema.MeiaEntrada(cliente);

        //Assert
        result.Should().BeFalse();
    }
    [Fact]
    public void Cinema_MeiaEntrada_DeveRetornarFalsoSeTodasCondicoesForemFalsas()
    {
        //Arrange
        var cliente = new Cliente
        {
            CPF = "12345678910",
            Nome = "Leandro",
            Estudante = false,
            DoadorDeSangue = false,
            TrabalhaNaPrefeitura = false,
            PrefeituraTemContratoComCinema = false
        };
        var cinema = new Cinema();

        //Act
        var result = cinema.MeiaEntrada(cliente);

        //Assert
        result.Should().BeFalse();
    }
}