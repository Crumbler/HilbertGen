

library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

use IEEE.NUMERIC_STD.ALL;
use IEEE.std_logic_arith.conv_integer;

--library UNISIM;
--use UNISIM.VComponents.all;

entity top is
    port(clk: in std_logic;
         Qx, Qy: out std_logic_vector(23 downto 0));
end top;

architecture Behavioral of top is

constant size: positive := 12;
constant cellsPerSide: positive := 2 ** size;

signal ind: unsigned(23 downto 0) := X"000000";

begin
    process (clk)
    variable x, y, hIndex, n, nHalf,
             tmp1: unsigned(23 downto 0);
    variable tmp2: unsigned(47 downto 0);
    begin
        if (rising_edge(clk)) then
            x := X"000000";
            y := X"000000";
        
            x(0) := ind(1);
            y(0) := ind(1) xor ind(0);
        
            hIndex := shift_right(ind, 2);
        
            n := X"000004";
        
            while n <= cellsPerSide loop
                nHalf := shift_right(n, 1);
            
                if (hIndex(1 downto 0) = 0) then
                    tmp1 := x;
                    x := y;
                    y := tmp1;
                elsif (hIndex(1 downto 0) = 1) then
                    y := y + nHalf;
                elsif (hIndex(1 downto 0) = 2) then
                    x := x + nHalf;
                    y := y + nHalf;
                elsif (hIndex(1 downto 0) = 3) then
                    tmp1 := y;
                    y := nHalf - x - 1;
                    tmp2 := nHalf * 2 - tmp1 - 1;
                    x := tmp2(23 downto 0);
                end if;
            
                hIndex := shift_right(hIndex, 2);
                
                n := shift_left(n, 1);
            end loop;
        
            Qx <= std_logic_vector(x);
            Qy <= std_logic_vector(y);
        
            ind <= ind + 1;
        end if;
    end process;
end Behavioral;
