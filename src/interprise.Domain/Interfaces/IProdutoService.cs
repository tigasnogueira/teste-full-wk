﻿using Business.Models;

namespace Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
        Task AtualizarCategoria(Categoria categoria);
    }
}
