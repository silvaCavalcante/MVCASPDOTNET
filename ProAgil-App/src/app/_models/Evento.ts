import { Lote } from './Lote';
import { RedeSocial } from './RedeSocial';
import { Palestrante } from './Palestrante';

export class Evento {

    /**
     *
     */
    constructor() {
        
    }

    id: number;
    local: string;
    dataEvento: Date;
    tema: string;
    qntPessoas: number;
    imagemUrl: string;
    telefone: string;
    email: string;
    lotes: Lote[];
    redeSociais: RedeSocial[];
    palestrantesEventos: Palestrante[];
}
