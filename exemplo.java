import java.util.HashMap;
import java.util.Map;

public class exemplo {
    public static void main(String[] args) {
        // Criando um HashMap para armazenar informações dos alunos (matrícula como
        // chave e nome como valor

        /*
         * Crie um hashmap para armazenar informações dos alunos (com matricula e nome),
         * logo apos procure se a uma matricula no hashmap e caso exista remova ela do
         * map (caso nao exista procure uma que exista e a remova), após isso veja qual
         * o tamanho do hashmap e o limpe deixando sem nada.
         */

        Map<Integer, String> alunos = new HashMap<Integer, String>();

        // Adicionando alguns alunos ao HashMap
        alunos.put(1001, "João");
        alunos.put(1002, "Maria");
        alunos.put(1003, "Pedro");

        // Imprimindo os alunos e suas matrículas
        System.out.println("Alunos:");

        for (Integer key : alunos.keySet()) {
            String value = alunos.get(key);
            System.out.println(key + " = " + value);
        }

        // Verificando se o HashMap contém a matrícula 1002
        Integer matricula = 1002;

        if (alunos.containsKey(matricula)) {
            System.out.println("\nO aluno com matrícula " + matricula + " está presente no HashMap.");
        } else {
            System.out.println("\nO aluno com matrícula " + matricula + " não está presente no HashMap.");
        }
        System.out.println();

        // Removendo o aluno com matrícula 1003

        alunos.remove(1003);

        System.out.println("Alunos após a remoção do aluno com matrícula 1003:");

        for (Integer key : alunos.keySet()) {
            String nome = alunos.get(key);
            System.out.println("Matrícula: " + key + ", Nome: " + nome);
        }

        // Verificando o tamanho do HashMap
        System.out.println("Total de alunos no HashMap: " + alunos.size());
        System.out.println();

        // Limpando o HashMap
        alunos.clear();
        System.out.println("Após limpar o HashMap, o tamanho é: " + alunos.size());
    }
}